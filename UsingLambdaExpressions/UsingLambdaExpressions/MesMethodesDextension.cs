using System;
using System.Collections.Generic;
using System.Text;

namespace UsingLambdaExpressions
{
    public static class MesMethodesDextension
    {
        /// <summary>
        /// Cette méthode indique si un nombre donné est pair
        /// </summary>
        /// <param name="pNumber">nombre donné</param>
        /// <returns>true si pair, false si impair</returns>
        public static bool IsEven(this int pNumber) // this veut dire que l'on fait une extension à la class int (on ajoute une méthode à int)
        {
            return pNumber % 2 == 0;
        }
    }
}
