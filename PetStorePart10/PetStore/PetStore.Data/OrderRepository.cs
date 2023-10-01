using PetStore.Data;
using Microsoft.EntityFrameworkCore;

public class OrderRepository
{
    private readonly ProductContext _dbContext;

    public OrderRepository()
    {
        _dbContext = new ProductContext();
    }

    public void AddOrder(Order order)
    {
        _dbContext.Orders.Add(order);
        _dbContext.SaveChanges();
    }

    public Order GetOrderById(int orderId)
    {
        return _dbContext.Orders.Include(x => x.Products).SingleOrDefault(o => o.OrderId == orderId);
    }
}
