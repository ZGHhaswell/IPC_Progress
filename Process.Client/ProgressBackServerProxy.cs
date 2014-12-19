using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progress.Core;

namespace Progress.Client
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ProgressBackServerProxy : IProgressBack
    {
        public void CallBack()
        {
            Instance.Instances.IsCanceled = true;
            Console.WriteLine("CallBack");
        }
    }
}
