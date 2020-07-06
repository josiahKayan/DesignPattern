using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.FactoryMethod
{
    public class ConcreteCreatorVeiculoFactory : VeiculoCreator
    {
        public override IVeiculoProduct GetVeiculo(string categoria)
        {
            switch (categoria)
            {
                case "leve":
                    return new MotoConcretProduct();
                case "pesado":
                    return new OnibusConcretProduct();
                default:
                    throw new Exception();

            }
        }
    }
}
