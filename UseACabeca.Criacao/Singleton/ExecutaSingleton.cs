using System;
using System.Collections.Generic;
using System.Text;

namespace UseACabeca.Criacao.Singleton
{
    public class ExecutaSingleton
    {

        // O padrão Singleton é utilizado, para que o aplicativo gere um única instância.
        //O código abaixo mostra o funcionamento, mesmo utilizando um novo objeto,
        // quandose tenta somar os valores, o valore anterior acaba assumindo o novo valor inserido.
        //
        // Para implementar o Singleton, basta criar uma variável estática e um construtor Privado, depois,
        //basta verificar se a variável é nula , caso se sim, basta instanciar, caso contrário, retornar a variável.

        public static void  Executa()
        {

            var instancia = Singleton.GetInstance();


            instancia.X = 1;

            instancia.Soma = 1 + instancia.X;

            var instancia2 = Singleton.GetInstance();

            instancia2.X = 1;

            instancia2.Soma = 0 + instancia2.X;

        }


    }
}
