using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Podium.ViewModels
{
    public class ApplicantSuccessViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public ApplicantSuccessViewModel(int id, string firstName)
        {
            this.Id = id;
            this.FirstName = firstName;
        }
    }
}
