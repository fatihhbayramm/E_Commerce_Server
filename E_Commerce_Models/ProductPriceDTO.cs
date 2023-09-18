using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Models
{
    public class ProductPriceDTO
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [Range(1, int.MaxValue,ErrorMessage="Price must be greater thab 1 Dolar" )]
        public string Price { get; set; }
    }
}
