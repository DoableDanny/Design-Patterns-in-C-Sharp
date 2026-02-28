using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Facade.MyTest
{
    public class OrderService
    {
        public void Order(OrderRequest orderRequest)
        {
            var auth = new Authenticate();

            var inventory = new Inventory();
            foreach (var id in orderRequest.ItemIds)
            {
                inventory.CheckInventory(id);
            }

            var payment = new Payment(orderRequest.Name, orderRequest.CardNumber, orderRequest.Amount);
            payment.Pay();

            var orderFulfillment = new OrderFulfillment(inventory);
            orderFulfillment.Fulfill(orderRequest.Name, orderRequest.Address, orderRequest.ItemIds);

        }
    }
}
