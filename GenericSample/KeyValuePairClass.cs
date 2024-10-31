using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class KeyValuePairClass<TKey, TValue>
    {
        public TKey ID { get; set; }
        public TValue Name { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Id: {ID.ToString()}\n");
            str.Append($"Name: {Name.ToString()}\n");
            str.Append($"Birth Date: {BirthDate}\n");
            str.Append(new string('-', 50));

            return str.ToString();
        }
    }
}
