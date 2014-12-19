using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Core
{
    [ServiceContract]
    public interface IProgress
    {
        [OperationContract]
        void Call();
    }
}
