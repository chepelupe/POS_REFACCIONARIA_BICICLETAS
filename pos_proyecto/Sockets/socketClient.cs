using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pos_proyecto.Sockets
{
    public class SocketClient
    {
        private TcpClient _tcpClient;
        private NetworkStream _stream;
        private readonly string _host;
        private readonly int _port;
        private CancellationTokenSource _cancellationTokenSource;

        public event Action<string> OnMessageReceived;
        public event Action<string> OnStockUpdated;
        public event Action<string> OnNewSale;
        public event Action<string> OnNewProduct;

        public SocketClient(string host = "localhost", int port = 5001)
        {
            _host = host;
            _port = port;
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                _tcpClient = new TcpClient();
                await _tcpClient.ConnectAsync(_host, _port);
                _stream = _tcpClient.GetStream();
                _cancellationTokenSource = new CancellationTokenSource();

                _ = Task.Run(ListenForMessagesAsync, _cancellationTokenSource.Token);
                await SendMessageAsync("client_connected", new { type = "pos_client", timestamp = DateTime.Now });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task ListenForMessagesAsync()
        {
            byte[] buffer = new byte[4096];

            while (!_cancellationTokenSource.Token.IsCancellationRequested &&
                   _tcpClient?.Connected == true)
            {
                try
                {
                    int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length, _cancellationTokenSource.Token);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        ProcessMessage(message);
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    OnMessageReceived?.Invoke($"Error: {ex.Message}");
                    break;
                }
            }
        }

        private void ProcessMessage(string message)
        {
            try
            {
                var socketMessage = JsonConvert.DeserializeObject<SocketMessage>(message);

                switch (socketMessage.Event)
                {
                    case "stock_updated":
                        OnStockUpdated?.Invoke(JsonConvert.SerializeObject(socketMessage.Data));
                        break;
                    case "new_sale":
                        OnNewSale?.Invoke(JsonConvert.SerializeObject(socketMessage.Data));
                        break;
                    case "new_product":
                        OnNewProduct?.Invoke(JsonConvert.SerializeObject(socketMessage.Data));
                        break;
                    default:
                        OnMessageReceived?.Invoke(message);
                        break;
                }
            }
            catch (Exception ex)
            {
                OnMessageReceived?.Invoke($"Error procesando mensaje: {ex.Message}");
            }
        }

        public async Task SendMessageAsync(string eventName, object data)
        {
            try
            {
                if (_tcpClient?.Connected == true)
                {
                    var message = new SocketMessage { Event = eventName, Data = data };
                    string json = JsonConvert.SerializeObject(message);
                    byte[] bytes = Encoding.UTF8.GetBytes(json);
                    await _stream.WriteAsync(bytes, 0, bytes.Length);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error enviando mensaje: {ex.Message}");
            }
        }

        public void Disconnect()
        {
            _cancellationTokenSource?.Cancel();
            _stream?.Close();
            _tcpClient?.Close();
        }
    }

    public class SocketMessage
    {
        public string Event { get; set; }
        public object Data { get; set; }
    }
}