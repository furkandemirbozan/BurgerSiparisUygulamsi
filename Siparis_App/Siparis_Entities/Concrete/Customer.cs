using Siparis_Entities.Abstract;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Entities.Concrete
{
    public class Customer:IEntity
    {
        //KULLANILMAMAKTADIR
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public Address Address { get; set; }
    }
}

