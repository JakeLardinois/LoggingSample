using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Logging;

namespace Logging
{
    [GeneratedCode("by hand, need to fix", "0")]
    public class LogManager
    {
        private static readonly IDictionary<Type, ILog> _loggers = new Dictionary<Type, ILog>();

        public static void Configure(string configFile)
        {
            Configure(configFile, null);
        }

        public static void Configure(string configFile, IDictionary<string, object> properties)
        {
            // using log4net implementation
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(configFile));

            if (properties != null)
            {
                // add custom properties
                foreach (var key in properties.Keys)
                {
                    log4net.GlobalContext.Properties[key] = properties[key];
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static ILog GetInstance<T>()
        {
            if (!_loggers.ContainsKey(typeof(T)))
            {
                _loggers.Add(typeof(T), new Logger<T>());
            }

            return _loggers[typeof(T)];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static void Debug<T>(object message, Exception exception)
        {
            GetInstance<T>().Debug(message, exception);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Debug<T>(object message)
        {
            GetInstance<T>().Debug(message);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Debug<T>(string format, params object[] args)
        {
            Debug<T>(string.Format(format, args));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static void Error<T>(object message, Exception exception)
        {
            GetInstance<T>().Error(message, exception);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Error<T>(object message)
        {
            GetInstance<T>().Error(message);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Error<T>(string format, params object[] args)
        {
            Error<T>(string.Format(format, args));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static void Fatal<T>(object message, Exception exception)
        {
            GetInstance<T>().Fatal(message, exception);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Fatal<T>(object message)
        {
            GetInstance<T>().Fatal(message);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Fatal<T>(string format, params object[] args)
        {
            Fatal<T>(string.Format(format, args));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static void Info<T>(object message, Exception exception)
        {
            GetInstance<T>().Info(message, exception);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Info<T>(object message)
        {
            GetInstance<T>().Info(message);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Info<T>(string format, params object[] args)
        {
            Info<T>(string.Format(format, args));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public static void Warn<T>(object message, Exception exception)
        {
            GetInstance<T>().Warn(message, exception);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Warn<T>(object message)
        {
            GetInstance<T>().Warn(message);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Justification = "need to fix")]
        public void Warn<T>(string format, params object[] args)
        {
            Warn<T>(string.Format(format, args));
        }
    }
}
