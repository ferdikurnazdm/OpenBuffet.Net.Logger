using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Domain.Entities {
    /// <summary>
    /// this entitiy represent the log content
    /// </summary>
    public sealed class LogContent {
        /// <summary>
        /// this field keeps the log creating time
        /// </summary>
        private DateTime _loggingTime = DateTime.Now;
        /// <summary>
        /// this field keep the log level
        /// </summary>
        private LogLevel _loggingLevel = LogLevel.NONE;
        /// <summary>
        /// this field keep the log message
        /// </summary>
        private string _loggingMessage = string.Empty;

        /// <summary>
        /// this property return the logging time
        /// </summary>
        public DateTime LogTime {
            get {  return _loggingTime; }
        }
        /// <summary>
        /// this property keeps the log level
        /// </summary>
        public LogLevel LogLevel {
            get { return _loggingLevel; }
            set {  _loggingLevel = value; }
        }
        /// <summary>
        /// this property keeps the log messsage
        /// </summary>
        public string LogMessage {
            get { return _loggingMessage; }
            set { _loggingMessage = value; }
        }
    }
}
