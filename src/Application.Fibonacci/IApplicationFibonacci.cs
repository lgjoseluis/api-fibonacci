using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fibonacci
{
    public interface IApplicationFibonacci
    {
        /// <summary>
        /// Algoritmo que implementa la serie de Fibonacci
        /// </summary>
        /// <param name="position">Posicion/índice</param>
        /// <returns>Valor de Fibonacci en el índice dado</returns>
        long SerieFibonacci(int position);
    }
}
