using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TentaMVC.Models
{
    public class Store
    {

        [Key]
        public int StoreID { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Must be shorter than 25 characters")]
        public string Name { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "Must be shorter than 30 characters")]
        public string Adress { get; set; }

        public IList<Product> Products { get; set; }
    }
}