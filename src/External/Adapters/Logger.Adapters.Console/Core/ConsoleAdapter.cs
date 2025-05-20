using Logger.Application.Ports;
using Logger.Domain.Entities;
using Logger.Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Adapters.Console.Core {
    /// <summary>
    /// this class is a console log adapter
    /// </summary>
    public sealed class ConsoleAdapter : ILogger {

        /// <summary>
        /// this method logging the given content
        /// </summary>
        /// <param name="logType">log type</param>
        /// <param name="content">log content</param>
        /// <param name="exception">return null if method runned succesfully 
        /// otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        public bool TryLogging(LogLevel logLevel, string content, out Exception exception) {
            bool result = false;
            exception = null;
            try {
                System.Console.WriteLine($"{DateTime.Now.ToString()}|{logLevel.ToString()}|{content}");
                result = true;
            }
            catch (Exception ex) {
                exception = ex;
                exception.Source = this.GetType().FullName;
                result = false;
            }
            return result;
        }

        /// <summary>
        /// this method logs the given parameters
        /// </summary>
        /// <param name="logContent">log content</param>
        /// <param name="exception">return null if method runned succesfully 
        /// otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        public bool TryLogging(LogContent logContent, out Exception exception) {
            bool result = false;
            exception = null;
            try {
                System.Console.WriteLine($"{DateTime.Now.ToString()}|{logContent.LogLevel.ToString()}|{logContent.LogMessage}");
                result = true;
            }
            catch (Exception ex) {
                exception = ex;
                exception.Source = this.GetType().FullName;
                result = false;
            }
            return result;
        }

        /// <summary>
        /// this method clean the logs
        /// </summary>
        /// <param name="exception">return null if method runned succesfully 
        /// otherwise return occured exception</param>
        /// <returns>return true if method runned succesfully otherwise return false</returns>
        public bool TryCleanLogs(out Exception exception) {
            bool result = false;
            exception = null;
            try {
                System.Console.Clear();
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
