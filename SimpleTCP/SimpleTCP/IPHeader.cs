using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTCP
{
    class IPHeader
    {
        ushort version;
        ushort IHL;
        ushort typeOfService;
        ushort totalLength;
        ushort identification;
        ushort flags;
        ushort fragmentOffset;
        ushort timeToLive;
        ushort protocol; // =6 ??
        ushort Checksum;
        ushort sourceIP;
        ushort destinationIP;
        ushort options;
        ushort padding;
    }
}
