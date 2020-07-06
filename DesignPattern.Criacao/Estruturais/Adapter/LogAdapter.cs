using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public class LogAdapter : ILogger
    {

        private readonly ILoggerMaster _loggerMaster;

        public LogAdapter(ILoggerMaster loggerMaster)
        {
            _loggerMaster = loggerMaster;
        }

        public void Log(string message)
        {
            _loggerMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _loggerMaster.LogException(exception);

        }
    }
}
