using System;
using System.Collections.Generic;
using System.Text;

namespace UseACabeca.Criacao.Singleton
{
    public class Singleton
    {

        private static Singleton _uniqueInstance;

        public int X;
        public int Soma;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {

            if (_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }

            return _uniqueInstance;
        }





    }
}
