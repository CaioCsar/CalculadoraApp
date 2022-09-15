using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraApp
{
    class Calculadora
    {
        private int x;
        private int y;

        public int n1(int n1)
        {
           return x=  n1;
        } 
        public int n2(int n2)
        {
            return y = n2;
        }

        public int somar()
        {
            return x + y;
        }

        public int subtrair()
        {
            return  x - y;
        }

        public int multiplicar()
        {
            return x * y;
        }

        public int dividir()
        {
            return x / y;
        }

    }
}
