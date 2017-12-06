using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
    
        [EmailAddress]
        public string ChildEmail { get; set; }

        [EmailAddress]
        public string ParentEmail { get; set; }
    }
}
