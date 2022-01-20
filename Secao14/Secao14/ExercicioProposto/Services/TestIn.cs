using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioProposto.Exceptions;
using ExercicioProposto.Entities;
using System.Text.RegularExpressions;

namespace ExercicioProposto.Services
{
    static class TestIn
    {
        public static bool Validation(string frase)
        {
            if (!frase.Contains('-'))
                throw new ServiceExceptions("Não foi colocado o caractere - separando nome e matricula!");
            else
            {
                string[] w = frase.Split('-');
                if(!Regex.IsMatch(w[1], @"^[0-9]+$"))
                    throw new ServiceExceptions("A matricula não foi digitada corretamente - utilize números de O a 9!");
                if (!Regex.IsMatch(w[0].ToLower(), @"^[a-z]+$"))
                    throw new ServiceExceptions("O nome não foi digitado corretamente - utilize apenas letras!");
                return true;
            }
        }
    }
}
