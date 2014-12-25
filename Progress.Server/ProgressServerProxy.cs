using System;
using System.ServiceModel;
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
