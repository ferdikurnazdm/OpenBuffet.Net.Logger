using Logger.Adapters.Console.Core;
using Logger.Application.Managers;
using Logger.Application.Ports;
using Logger.Domain.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

//arr
//act
//ass

namespace Logger.Test.ConsoleAdapterTest {
    [TestClass]
    public class ConsoleAdapterTest {
        [TestMethod]
        public void Console_adapter_logging_test() {
            //arr
            Exception exception = null;
            List<ILogger> loggers = new List<ILogger>();
            loggers.Add(new ConsoleAdapter());
            LoggerManager loggerManager = new LoggerManager(loggers.AsEnumerable());
            //act
            bool result = loggerManager.TryLogging(
                logLevel: LogLevel.INFO,
                content: "test",
                out exception
                );
            //ass
            Assert.IsTrue(result);
        }
    }
}
