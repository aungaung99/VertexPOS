using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VertexPOS.Core.Interfaces;

namespace VertexPOS.Infrastructure.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }

        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }

        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            _logger.LogError(message, args);
        }

        public void LogCritical(string message, params object[] args)
        {
            _logger.LogCritical(message, args);
        }
    }
}
