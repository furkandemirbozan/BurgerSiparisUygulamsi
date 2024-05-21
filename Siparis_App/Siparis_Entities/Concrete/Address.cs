using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Entities.Concrete
{
    public class Address
    {
        //Kullanmadım
        public int Id { get; set; }
        public string Street { get; set; }
        public bool IsDeleted { get; set; }
        public Worker Worker { get; set; }

    }
}
