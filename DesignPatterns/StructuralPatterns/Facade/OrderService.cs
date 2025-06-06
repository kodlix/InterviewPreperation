namespace DesignPatterns.StructuralPatterns.Facade
{
    public class OrderService
    {
        public void Order(OrderRequest orderReq)
        {
            var auth = new Authenticate();
            auth.Login("mike", "12345");

            var inventory = new Inventory();
            foreach (var id in orderReq.ItemIds)
            {
                inventory.CheckInventory(id);
            }

            var payment = new Payment(orderReq.Name, orderReq.CardNumber, orderReq.Amount);
            payment.Pay();

            var orderFulfillment = new OrderFulfillment(inventory);
            orderFulfillment.Fulfill(orderReq.Name, orderReq.Address, orderReq.ItemIds);
        }
    }
}