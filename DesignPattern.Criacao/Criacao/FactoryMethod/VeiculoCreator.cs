using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.FactoryMethod
{
    public abstract class VeiculoCreator
    {

        public abstract IVeiculoProduct GetVeiculo(string categoria);


    }
}
