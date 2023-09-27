using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context c = new();
        public void StockDecrease(int id, int amount)
        {
            var value = c.Products.Find(id);
            value.ProductStock -= amount;
            c.SaveChanges();
        }
    }
}
