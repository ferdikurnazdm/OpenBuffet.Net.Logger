using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Domain.Entities {
    /// <summary>
    /// this class represent the log content
    /// </summary>
    public sealed class LogContent {
        /// <summary>
        /// this property keep the log level
        /// </summary>
        public LogLevel LogLevel { get; set; }
        /// <summary>
        /// this property keep the log message
        /// </summary>
        public string LogMessage { get; set; }
    }
}
