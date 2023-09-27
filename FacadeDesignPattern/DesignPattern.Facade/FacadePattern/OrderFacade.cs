using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new();
        OrderDetail orderDetail = new();
        ProductStock productStock = new();

        AddOrder addOrder = new();
        AddOrderDetail addOrderDetail = new();

        public void CompleteOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            orderDetail.OrderId = orderId;
            orderDetail.CustomerId = customerId;
            orderDetail.ProductId = productId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            decimal totalProductPrice = productCount * productPrice;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productId, productCount);
        }
        public void CompleteOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
