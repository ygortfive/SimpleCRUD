using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int IDProduct { get; set; }
        [Required]
        [Display(Name = "Nome do Produto")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Valor do Produto")]
        public float Price { get; set; }
    }
}
