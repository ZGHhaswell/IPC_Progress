using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progress.Core;

namespace Progress.Server
{
    public class ProgressBackClientProxy : ClientBase<IProgressBack>, IProgressBack
    {
        public ProgressBackClientProxy()
            :base()
        {
            
        }


        public void CallBack()
        {
            this.Channel.CallBack();
        }
    }
}
