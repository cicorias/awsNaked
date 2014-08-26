using Amazon.Route53.Model;
using Microsoft.Azure.WebJobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshRt53
{
    public class UpdateRt53
    {

        [NoAutomaticTrigger]
        internal static void UpdateHostRecord([Table("Rt53DnsARecords")] 
            IQueryable<DnsRecord> records)
        {

            foreach (var item in records)
            {
                Console.WriteLine("HOST: {0}  - IPAddress:{1}", item.RowKey, item.IPAddress);
                CheckAndSet(item.RowKey, item.IPAddress, item.Alias, item.ZoneId);
            }
        }


        public static void CheckAndSet(string hostName, string ipAddress, string alias, string zoneId)
        {
            var awsConfig = new Amazon.Route53.AmazonRoute53Config
            {
                ServiceURL = "https://route53.amazonaws.com",
            };

            var aws53Client = new Amazon.Route53.AmazonRoute53Client(awsConfig);

            var recordRequest = new ListResourceRecordSetsRequest
            {
                HostedZoneId = zoneId,
                MaxItems = "10",
                StartRecordType = "A",
                StartRecordName = hostName
            };

            var rv = aws53Client.ListResourceRecordSets(recordRequest);
            var aRecord = rv.ResourceRecordSets.Where(d => d.Type.Value.Equals("A")).FirstOrDefault()
                .ResourceRecords.FirstOrDefault();


            var zoneIp = aRecord.Value;


            var currentIp = GetCurrentIp(alias);


            if (zoneIp != currentIp)
            {
                UpdateIp();
            }


        }

        private static void UpdateIp()
        {
            throw new NotImplementedException();
        }

        static string GetCurrentIp(string cnameHost)
        {
            var ip = System.Net.Dns.GetHostEntry(cnameHost);

            var rv = ip.AddressList.FirstOrDefault();

            return rv.ToString();
        }
    }
}
