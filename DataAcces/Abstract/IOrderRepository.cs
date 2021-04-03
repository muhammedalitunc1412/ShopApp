using ShopApp.Entity;
using System.Collections.Generic;

namespace DataAcces.Abstract
{
    public interface IOrderRepository: IRepository<Order>
    {
        List<Order> GetOrders(string userId);

    }
}