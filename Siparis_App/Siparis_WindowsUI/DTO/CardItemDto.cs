using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_WindowsUI.DTO
{
    public class CardItemDto
    {

        
        [DisplayName("Adet")]
        public int Quantity { get; set; }
        [DisplayName("Fiyat")]
        public string Price { get; set; }

        [DisplayName("Eklenen ürün")]
        public int ProductId { get; set; }
        
        [DisplayName("Ürün")]
        public string? ProductName { get; set; }

        public bool KetçapOlsunMu{ get; set; }
        public bool MayonezOlsunMu{ get; set; }
    }
}
