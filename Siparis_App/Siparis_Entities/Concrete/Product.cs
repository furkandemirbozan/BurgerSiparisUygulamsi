using Siparis_Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; }

        
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
