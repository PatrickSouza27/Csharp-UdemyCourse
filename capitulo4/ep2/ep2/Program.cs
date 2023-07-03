using System;

namespace ep2
{
    class Program
    {
        static void Main()
        {
            double? x = null;
            double? y = x ?? 10.0;

 

    

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é null");
            }
        }
    }
}
