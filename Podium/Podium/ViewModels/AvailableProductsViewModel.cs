using Podium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.ViewModels
{
    public class AvailableProductsViewModel
    { 
        public string FirstName { get; set; }
        public IEnumerable<Product> Products { get; set; } 
    }
}
