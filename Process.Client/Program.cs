using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("客户端开启------");
            var m_Service = new ServiceHost(typeof(ProgressBackServerProxy));

            m_Service.Open();


            using (var progressProxy = new ProgressClientProxy())
            {
                for (int i = 0; i < 100; i++)
                {
                    if(Instance.Instances.IsCanceled)
                        break;
                    progressProxy.Call();
                    Console.WriteLine("Client Called");
                }

            }



            Console.ReadLine();
        }
    }
}
