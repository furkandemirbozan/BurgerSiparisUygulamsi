using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Entities.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public IList<OrderItem> OrderItems { get; set; }
    }
}
