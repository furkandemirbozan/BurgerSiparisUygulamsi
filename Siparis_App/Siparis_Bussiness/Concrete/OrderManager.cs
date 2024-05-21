using Siparis_Bussiness.Abstract;
using Siparis_DAL.Abstract;
using Siparis_DAL.Concrete.EfCore;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Concrete
{
    public class OrderManager : IOrderService
    {
        EfCoreOrderDal _orderDal=new EfCoreOrderDal();
        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.GetById(orderId);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
