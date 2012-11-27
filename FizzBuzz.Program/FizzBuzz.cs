using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FizzBuzzExemploTDD
{
    public class FizzBuzz
    {
        public string ObterNumeroFizzBuzz(int numero)
        {
            string numeroFizzBuzz = numero.ToString();

            if (numero % 15 == 0)
                numeroFizzBuzz = "FizzBuzz";
            else if (numero % 3 == 0)
                numeroFizzBuzz = "Fizz";
            else if (numero % 5 == 0)
                numeroFizzBuzz = "Buzz";

            return numeroFizzBuzz;
        }
    }
}
