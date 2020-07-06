using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.FactoryMethod
{
    public class OnibusConcretProduct : IVeiculoProduct
    {
        public void Limite(int limite)
        {
            limite = 60;
        }
    }
}
