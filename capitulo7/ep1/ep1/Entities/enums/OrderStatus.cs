using System;

namespace ep1.Entities.enums
{
    enum OrderStatus : int
    {
         PendingPayment = 0,
         Processing = 1,
         Shipped = 2,
         Delivered = 3
    }
}
