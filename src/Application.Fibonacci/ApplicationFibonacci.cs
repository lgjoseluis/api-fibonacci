using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fibonacci
{
    public class ApplicationFibonacci:IApplicationFibonacci
    {

        public long SerieFibonacci(int position)
        {
            long result = 0;
            long temporal = 0;
            long siguiente = 1;

            for (int x = 1; x <= position; x++)
            {               
                temporal = result;
                result = siguiente;
                siguiente = siguiente + temporal;
            }

            return result;
        }
    }
}
