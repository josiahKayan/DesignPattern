using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public interface ILogger
    {

        void Log(string message);

        void LogError(Exception exception);


    }
}
