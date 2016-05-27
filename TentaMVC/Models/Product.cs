using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }



        [Required]
        [StringLength(25, ErrorMessage = "Must be shorter than 25 characters")]
        public string Name { get; set; }



        [Display(Description = "Discription")]
        [DataType(DataType.MultilineText)]
        public string ProductText { get; set; }



        [Display(Name = "Product Number")]
        [Required]
        [ProductValidation]
        public string ProductNumber { get; set; }


        [Range(0,9999)]
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Products in Stock")]
        [Range(0,99999)]
        public int ProductsInStock { get; set; }

    }
}
