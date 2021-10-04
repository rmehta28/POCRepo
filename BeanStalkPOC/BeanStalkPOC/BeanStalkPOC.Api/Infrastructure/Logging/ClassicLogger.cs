using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace BeanStalkPOC.Api.Infrastructure.Logging
{
    /// <summary>
    /// Custom logger for framework.
    /// </summary>
    public class ClassicLogger : ILogger
    {
        readonly string loggerName;
        readonly LoggerConfiguration loggerConfig;

        /// <summary>
        /// Initializes classic logger.
        /// </summary>
        /// <param name="name">name string</param>
        /// <param name="config">logger configuration object</param>
        public ClassicLogger(string name, LoggerConfiguration config)
        {
            this.loggerName = name;
            loggerConfig = config;
        }

        /// <summary>
        /// Begin scope
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="state"></param>
        /// <returns></returns>
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        /// <summary>
        /// IsEnables method
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Log method
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="logLevel"></param>
        /// <param name="eventId"></param>
        /// <param name="state"></param>
        /// <param name="exception"></param>
        /// <param name="formatter"></param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = string.Format("{0}: {1} - {2}", logLevel.ToString(), eventId.Id, formatter(state, exception));
            WriteTextToFile(message);
        }

        /// <summary>
        /// Write text to file.
        /// </summary>
        /// <param name="message"></param>
        private void WriteTextToFile(string message)
        {
            string path = @"D:\";
            if (!Directory.Exists(path))
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
            }

            path = string.Format(@"{0}\{1}.txt", path, DateTime.Now.ToShortDateString());

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }

            //using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Write))
            using (FileStream fileStream = File.Open(path, FileMode.Open))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }

                fileStream.Close();
            }
        }
    }
}
