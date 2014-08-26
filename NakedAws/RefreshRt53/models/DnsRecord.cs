using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshRt53
{
    public class DnsRecord : TableEntity
    {
        public string IPAddress { get; set; }
        public string ZoneId { get; set; }
        public string Alias { get; set; }
    }
}
