using System;
using System.Collections.Generic;
using System.Text;

namespace project.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
