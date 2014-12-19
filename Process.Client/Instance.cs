using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress.Client
{
    public class Instance
    {
        private static Instance _instance;

        public static Instance Instances
        {
            get
            {
                return _instance ?? (_instance = new Instance())
                ;
            }
        }

        private Instance()
        {
            
        }

        public bool IsCanceled;
    }
}
