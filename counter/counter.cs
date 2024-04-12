using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    internal class counter
    {
        // TODO lite variabler
        int value = 0;
        // ökar räknaren med ett
        public void Increment()
        {
            value++; 
        }

        // återställer värdet till noll
        public void Reset()
        {
            value = 0; 
        }

        // ger värdet på räknaren
        public int GetValue()
        {
            // TODO
            return value;
        }
    }
}
