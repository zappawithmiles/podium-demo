using Podium.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<Product> Products;
        [Required]
        public int ApplicantId { get; set; }
        [Range(5, double.MaxValue)]
        public double PropertyValue { get; set; }
        [Range(5, double.MaxValue)]
        public double DepositAmount { get; set; }
    }
}
