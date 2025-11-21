using pos_proyecto.Sockets;
using System;

namespace pos_proyecto.Servicios
{
    public class ServiceManager
    {
        private static ApiService _apiService;
        private static SocketClient _socketClient;

        public static ApiService GetApiService()
        {
            return _apiService ??= new ApiService();
        }

        public static SocketClient GetSocketClient()
        {
            return _socketClient ??= new SocketClient();
        }

        public static void InitializeServices()
        {
            _apiService = new ApiService();
            _socketClient = new SocketClient();
        }
    }
}