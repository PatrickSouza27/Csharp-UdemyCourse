using System;
using ep1.Entities.enums;

namespace ep1.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return ($"{Id}, {Moment}, {Status}");
        }
    }
}
