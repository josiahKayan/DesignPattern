using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Facade
{
    public class ExecutaFacade
    {

        public ExecutaFacade()
        {

            // Cria uma instância do Facade
            Facade facade = new Facade();


            // Cria uma instância de um  novo Cliente informando o nome
            Cliente cliente = new Cliente("Macoratti");

            //Utiliza o Facade para verificar condições de concessão ou não
            var resultado = facade.ConcederEmprestimo(cliente, 1200);

        }


    }
}
