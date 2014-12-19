using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
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

            int sum = 0;

            using (var progressProxy = new ProgressClientProxy())
            {
                for (int i = 0; i < 100; i++)
                {
                    if(Instance.Instances.IsCanceled)
                        break;
                    progressProxy.Call();
                    for (int j = 0; j < 1000000000; j++)
                    {
                        int a = 1 + 1;
                    }
                    sum++;
                    Console.WriteLine("Client Called");
                }

            }


            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
