using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;

namespace BeanStalkPOC.Api.Infrastructure.Logging
{
    /// <summary>
    /// Logger provider.
    /// </summary>
    public class ClassicLoggerProvider : ILoggerProvider
    {
        readonly LoggerConfiguration loggerConfig;
        readonly ConcurrentDictionary<string, ClassicLogger> loggers =
         new ConcurrentDictionary<string, ClassicLogger>();

        /// <summary>
        /// Initializes classic logger provider.
        /// </summary>
        /// <param name="config"></param>
        public ClassicLoggerProvider(LoggerConfiguration config)
        {
            loggerConfig = config;
        }

        /// <summary>
        /// Create logger method.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public ILogger CreateLogger(string category)
        {
            return loggers.GetOrAdd(category,
             name => new ClassicLogger(name, loggerConfig));
        }

        /// <summary>
        /// Method to dispose.
        /// </summary>
        public void Dispose()
        {
            //Write code here to dispose the resources
        }
    }
}
