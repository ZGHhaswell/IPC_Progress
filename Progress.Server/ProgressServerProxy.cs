using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progress.Core;

namespace Progress.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ProgressServerProxy : IProgress
    {
        private bool isCalled = false;

        public void Call()
        {
            Console.WriteLine("Server Called");

            if (!isCalled)
            {
                Action action = () =>
                {
                    using (var progressBackClientProxy = new ProgressBackClientProxy())
                    {
                        progressBackClientProxy.CallBack();
                    }
                    Console.WriteLine("11");
                };
                action.BeginInvoke(null, null);
                isCalled = true;
            }
            
        }
    }
}
