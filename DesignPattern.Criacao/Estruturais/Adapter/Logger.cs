using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
