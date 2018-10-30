using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> GetAvailableProducts(int applicantId, double propertyValue, double depositAmount)
        {
            
            IEnumerable<Product> result = Enumerable.Empty<Product>();
            bool applicantIsOver18 = IsApplicantOver18(applicantId);
            double LTV = (propertyValue - depositAmount) / propertyValue;

            if (applicantIsOver18)
            {
                result = _appDbContext.Products.Where(product => product.LoanToValue < LTV);
            }
            
            return result;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _appDbContext.Products;
        }

        private bool IsApplicantOver18(int applicantId)
        {
            DateTime dob =
                (
                from a in _appDbContext.Applicants
                where a.Id == applicantId
                select a.Dob
                ).FirstOrDefault();

            return (dob <= DateTime.Now.AddYears(-18));
        }
    }
}


    