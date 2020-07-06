using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public class LogNetMaster : ILoggerMaster
    {
        public void LogException(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
