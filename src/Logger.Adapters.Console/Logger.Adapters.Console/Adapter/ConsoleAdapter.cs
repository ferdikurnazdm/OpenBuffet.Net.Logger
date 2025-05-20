using Logger.Application.Ports;
using Logger.Domain.Entities;
using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Adapters.Console.Adapter {
    /// <summary>
    /// this class a adapter for console logger
    /// </summary>
    public sealed class ConsoleAdapter : ILogger {

        public bool TryCleanLogs(out Exception exception) {
            throw new NotImplementedException();
        }

        public bool TryLogging(LogLevel logLevel, string content, out Exception exception) {
            throw new NotImplementedException();
        }

        public bool TryLogging(LogContent logContent, out Exception exception) {
            throw new NotImplementedException();
        }
    }
}
