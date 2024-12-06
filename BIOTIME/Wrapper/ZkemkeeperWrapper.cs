using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BIOTIME.Wrapper
{
    public class ZkemkeeperWrapper
    {
        [DllImport("zkemkeeper.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Connect_Net(string ipAddress, int port);

        [DllImport("zkemkeeper.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool Disconnect();

        [DllImport("zkemkeeper.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ReadAllUserID(int deviceNumber);

    }
}
