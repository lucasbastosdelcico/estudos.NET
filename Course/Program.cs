using Course.Entities;
using Course.Entities.Enums;
using System;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 180,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };

            string texto = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

        }
    }
}