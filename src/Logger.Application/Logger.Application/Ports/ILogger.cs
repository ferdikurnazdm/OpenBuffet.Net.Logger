using Logger.Domain.Entities;
using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Application.Ports {
    /// <summary>
    /// this interface represent 
    /// the loggers talents
    /// </summary>
    public interface ILogger {
        /// <summary>
        /// this method logs the given parameters
        /// </summary>
        /// <param name="logType">log type</param>
        /// <param name="content">log content</param>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryLogging(LogLevel logLevel, string content, out Exception exception);
        /// <summary>
        /// this method logs the given parameters
        /// </summary>
        /// <param name="logContent">log content</param>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryLogging(LogContent logContent, out Exception exception);
        /// <summary>
        /// this method clean the all logs
        /// </summary>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryCleanLogs(out Exception exception);
    }
}
