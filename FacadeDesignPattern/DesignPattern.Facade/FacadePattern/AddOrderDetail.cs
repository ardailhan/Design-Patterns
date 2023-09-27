using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrderDetail
    {
        Context c = new();
        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            c.OrderDetails.Add(orderDetail);
            c.SaveChanges();
        }
    }
}
