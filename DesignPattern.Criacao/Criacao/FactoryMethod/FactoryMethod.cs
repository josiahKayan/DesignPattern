using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.FactoryMethod
{
    public class FactoryMethod
    {

        FactoryMethod()
        {
            ConcreteCreatorVeiculoFactory concrete = new ConcreteCreatorVeiculoFactory();
            var moto = concrete.GetVeiculo("leve");
            moto.Limite(100);
        }

        


    }
}
