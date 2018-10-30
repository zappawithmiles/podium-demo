using System;
using System.Linq;

namespace Podium.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            SeedApplicants(context);
            SeedProducts(context);

        }

        private static void SeedApplicants(AppDbContext context)
        {
            if (!context.Applicants.Any())
            {
                context.AddRange(

                    new Applicant
                    {
                        FirstName = "Francis",
                        LastName = "Zappa",
                        Dob = new DateTime(1987, 01, 01),
                        Email = "over18@somedomain.com"
                    },

                    new Applicant
                    {
                        FirstName = "Miles",
                        LastName = "Davis",
                        Dob = new DateTime(2011, 10, 13),
                        Email = "under18@somedomain.com"
                    });
            }
            context.SaveChanges();
        }

        private static void SeedProducts(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.AddRange(

                new Product
                {
                    Lender = "Bank A",
                    InterestRate = 0.02,
                    InterestType = "Variable",
                    LoanToValue = 0.6
                },

                new Product
                {
                    Lender = "Bank B",
                    InterestRate = 0.03,
                    InterestType = "Fixed",
                    LoanToValue = 0.6
                },

                new Product
                {
                    Lender = "Bank C",
                    InterestRate = 0.04,
                    InterestType = "Variable",
                    LoanToValue = 0.9
                });
            }
            context.SaveChanges();
        }
    }
}
