using Microsoft.Extensions.Logging;

namespace BeanStalkPOC.Api.Infrastructure.Logging
{
    /// <summary>
    /// Logger configuration.
    /// </summary>
    public class LoggerConfiguration
    {
        /// <summary>
        /// Log level
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;

        /// <summary>
        /// Event id
        /// </summary>
        public int EventId { get; set; } = 0;
    }
}
