using Siparis_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Entities.Concrete
{
    public class Worker:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
