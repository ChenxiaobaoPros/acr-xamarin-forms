﻿using System;
using System.Threading.Tasks;


namespace Acr.XamForms.Network {

    public interface INetworkService {

        bool IsConnected { get; }
        bool IsWifi { get; }
        bool IsMobile { get; }
        Task<bool> IsHostReachable(string host);
        event EventHandler<NetworkStatusChangedEventArgs> NetworkStatusChanged; 
    }
}
