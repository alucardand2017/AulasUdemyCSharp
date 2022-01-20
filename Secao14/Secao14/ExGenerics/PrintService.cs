using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics
{
    class PrintService<T>
    {
        private T[] Value = new T[10];
        private int count = 0;
        public void AddValue(T value)
        {
            Value[count] = value;
            count++;
        }
        public T First()
        {
            return Value[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int i = 0;  i < count; i++)
            {
                if (i == count - 1)
                {
                    Console.WriteLine(Value[i] + "]");
                    return;
                }
                Console.Write(Value[i] + ", ");
            }
        }
    }
}
