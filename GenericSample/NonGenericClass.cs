using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class NonGenericClass
    {
        public void Print<T> (T value)
        {
            Console.WriteLine($"{typeof(T)} type of data ({value}) is printed");
        }
    }
}
