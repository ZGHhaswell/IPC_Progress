using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progress.Core;

namespace Progress.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("服务器开启-------------------");

 
            var m_Service = new ServiceHost(typeof(ProgressServerProxy) );
  
            m_Service.Open();

            Console.ReadLine();
        }
    }
}
