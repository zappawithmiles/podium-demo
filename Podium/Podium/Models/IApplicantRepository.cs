using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Podium.Models
{
    public interface IApplicantRepository
    {
        void AddApplicant(Applicant applicant);
        IEnumerable<Applicant> GetAllApplicants();
        string GetApplicantFirstName(int id);
    }
}
