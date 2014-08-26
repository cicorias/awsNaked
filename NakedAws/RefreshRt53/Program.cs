using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshRt53
{
    class Program
    {
        static void Main(string[] args)
        {
            var jobHost = new JobHost();
            jobHost.Call(typeof(UpdateRt53).GetMethod("UpdateHostRecord"));

        }
    }

}
