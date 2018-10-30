using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Podium.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Podium.Models
{
    public class ApplicantController : Controller
    {
        private readonly IApplicantRepository _applicantRepository;

        public ApplicantController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewApplicant(Applicant applicant)
        {
            
            ApplicantSuccessViewModel applicantSuccessViewModel = new ApplicantSuccessViewModel(applicant.Id, applicant.FirstName);

            if (ModelState.IsValid)
            {
                return View("Success", applicantSuccessViewModel);
            }
            else
            {
                return View("Index", applicant);
            }
        }

        [HttpGet]
        public IEnumerable<Applicant> GetAllApplicants()
        {
            return _applicantRepository.GetAllApplicants();
        }
    }
}
