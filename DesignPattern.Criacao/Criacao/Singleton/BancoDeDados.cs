using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacao.Criacao.Singleton
{
    public class BancoDeDados
    {

        private static BancoDeDados instance;

        private  BancoDeDados()
        {
            Console.WriteLine("Banco de Dados");
        }


        public  static BancoDeDados GetInstance()
        {
            if (instance == null)
            {
                instance =  new BancoDeDados();
            }

            return  instance;
        }

    }
}
