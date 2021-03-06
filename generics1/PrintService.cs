using System;

namespace generics1
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValues(T values)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("Serviço de impressão está Cheio!");
            }
            _values[_count] = values;
            _count++;
        }

        public T Fisrt()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("O serviço de impressão está vazio!");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count -1]);
            }
            Console.WriteLine("]");
        }
    }
}
