using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class GenericMethod<T>
    {
        public T[] arr = new T[5];

        public void AddElement(int index, T data)
        {
            if(index >= 0 && index < 5)
                arr[index] = data;
        }

        public void AddElement(string index, T data){}
        public void AddElement(T data) { }

        public T GetData(int index) // Gelen type'a göre dönüş type'ını ayarlar
        {
            if (index >= 0 && index < 5)
            return arr[index];
            else
                return default(T); // type'ın default değeri
        }
    }
}
