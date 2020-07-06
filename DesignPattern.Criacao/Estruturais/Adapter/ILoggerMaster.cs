using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public interface ILoggerMaster
    {

        void LogInfo(string message);

        void LogException(Exception exception);

    }
}
