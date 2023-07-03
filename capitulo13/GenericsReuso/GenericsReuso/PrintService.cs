using System.Collections.Immutable;

namespace GenericsReuso
{
    class PrintService<T>
    {
        private T[] Value = new T[10];
        private int _Cont = 0;

        public void AddValue(T value)
        {
            if (_Cont >= 10)
            {
                throw new InvalidOperationException("ERROR");
            }
            else
            {
                Value[_Cont] = value;
                _Cont++;
            }
        }
        public T First() => Value[0];    
        public void Print()
        {
            Console.Write("[");
            foreach (T value in Value)
            {

                Console.Write(value);

            }
            Console.WriteLine("]");
        }

    }
}
