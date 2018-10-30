using Microsoft.AspNetCore.Mvc;
using Podium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podium.Models
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly AppDbContext _appDbContext;

        public ApplicantRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddApplicant(Applicant applicant)
        {
            _appDbContext.Applicants.Add(applicant);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Applicant> GetAllApplicants()
        {
            return _appDbContext.Applicants;
        }

        public string GetApplicantFirstName(int id)
        {
            return _appDbContext.Applicants.First(a => a.Id == id).FirstName;
        }


    }
}
