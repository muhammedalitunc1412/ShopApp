using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);

    }
}
