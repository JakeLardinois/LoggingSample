using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging;

namespace LoggingSample
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetInstance<Program>();
        private static readonly string ServicePath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).FullName;


        static void Main(string[] args)
        {
            ConfigureLogging();

            var classInstance = new MyClass();
        }

        private static void ConfigureLogging()
        {
            //Could add some more properties to log here if you want to...
            IDictionary<string, object> loggingProperties = new Dictionary<string, object>();

            var mappedPath = ServicePath + "LoggingSample.exe.config";
            LogManager.Configure(mappedPath, loggingProperties);

            Logger.Info("Logging Started...");
        }
    }
}
