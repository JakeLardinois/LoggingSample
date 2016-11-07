using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;

namespace LoggingSample
{
    public class MyClass
    {
        private static readonly ILog Logger = LogManager.GetInstance<MyClass>();

        public MyClass()
        {
            Logger.Debug("Logging in my Class");
        }
    }
}
