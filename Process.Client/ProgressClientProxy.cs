﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progress.Core;
using System.ServiceModel;

namespace Progress.Client
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple) ]
    public class ProgressClientProxy : ClientBase<IProgress> , IProgress
    {
        public ProgressClientProxy()
            :base()
        {
            
        }

        public void Call()
        {
            this.Channel.Call();
        }
    }
}
