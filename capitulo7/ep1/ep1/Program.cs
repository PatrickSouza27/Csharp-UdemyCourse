using System;
using ep1.Entities;
using ep1.Entities.enums;

namespace ep1
{
    class Program
    {
        static void Main()
        {
            Order x = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(x);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus y = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(y);
        }
    }
}