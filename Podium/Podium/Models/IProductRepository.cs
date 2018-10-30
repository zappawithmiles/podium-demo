using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAvailableProducts(int applicantId, double propertyValue, double depositAmount);
        IEnumerable<Product> GetAllProducts();
    }
}
