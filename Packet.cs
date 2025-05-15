using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group10_proj
{
    public class Packet
    {
        public string Src_IP { get; set; }
        public string Dst_IP { get; set; }
        public int Src_Port { get; set; }
        public int Dst_Port { get; set; }
        public string Protocol { get; set; }
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
