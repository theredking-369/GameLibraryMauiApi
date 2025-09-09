
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGameLibrary.Configuration
{
    
    public class ApplicationSettings
    {

        public string ServerName { get; set; }
        public int Port { get; set; }
        public string BaseRoute { get; set; }
        public string ServiceUrl { get; set; }

        public ApplicationSettings()
        {
            ServerName = "localhoast";
#if DEBUG
            if (DeviceInfo.Platform == DevicePlatform.Android)
                ServerName = "10.0.2.2";
#endif
            Port = 7012;
            BaseRoute = "api/GameStuff";
            ServiceUrl = $"https://{ServerName}:{Port}/{BaseRoute}";

        }
        
    }
}
