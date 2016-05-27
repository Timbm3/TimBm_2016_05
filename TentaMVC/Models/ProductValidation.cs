using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TentaMVC.Models
{
    public class ProductValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            // var toCheckk = Regex.IsMatch()

            //var toCheck = value.ToString().ToLower();
            var toCheck = value.ToString().ToLower();
            return toCheck.StartsWith("p-");

// &&  toCheck.StartsWith(@"/\d{2}-\d{5}/")

        }

        public override string FormatErrorMessage(string name)
        {
            return name + " Should start with P-";
        }
    }
}
