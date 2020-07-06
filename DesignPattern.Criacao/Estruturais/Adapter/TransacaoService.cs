using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Adapter
{
    public class TransacaoService
    {

        private readonly ILogger _logger;


        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizaTransacao()
        {
            _logger.Log("Transacao Feita");
        }

    }
}
