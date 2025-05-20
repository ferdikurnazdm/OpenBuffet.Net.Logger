using Logger.Application.Ports;
using Logger.Domain.Entities;
using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Application.Managers {
    /// <summary>
    /// this class manage the logger services
    /// </summary>
    public sealed class LoggerManager {
        /// <summary>
        /// this field keeps the loggers
        /// </summary>
        private readonly IEnumerable<ILogger> _loggers;

        /// <summary>
        /// this constructor sets the loggers
        /// </summary>
        /// <param name="loggers">loggers</param>
        public LoggerManager(IEnumerable<ILogger> loggers) {
            _loggers = loggers;
        }



        /// <summary>
        /// this method logs the given parameters
        /// </summary>
        /// <param name="logType">log type</param>
        /// <param name="content">log content</param>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryLogging(LogLevel logLevel, string content, out Exception exception) {
            bool result = false;
            exception = null;
            try {
                foreach (var logger in _loggers) {
                    if (!logger.TryLogging(logLevel, content, out exception)) {
                        return false;
                    }
                }
                result = true;
            }
            catch (Exception ex) {
                exception = ex;
                result = false;
            }
            return result;
        }
        /// <summary>
        /// this method logs the given parameters
        /// </summary>
        /// <param name="logContent">log content</param>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryLogging(LogContent logContent, out Exception exception) {
            bool result = false;
            exception = null;
            try {
                foreach (var logger in _loggers) {
                    if (!logger.TryLogging(logContent, out exception)) {
                        return false;
                    }
                }
                result = true;
            }
            catch (Exception ex) {
                exception = ex;
                result = false;
            }
            return result;
        }
        /// <summary>
        /// this method clean the all logs
        /// </summary>
        /// <param name="exception">return null if method runned succesfully otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        bool TryCleanLogs(out Exception exception) {
            bool result = false;
            exception = null;
            try {
                foreach (var logger in _loggers) {
                    if (!logger.TryCleanLogs(out exception)) {
                        return false;
                    }
                }
                result = true;
            }
            catch (Exception ex) {
                exception = ex;
                exception.Source = this.GetType().FullName;
                result = false;
            }
            return result;
        }





    }
}
