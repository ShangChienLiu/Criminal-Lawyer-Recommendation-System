using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LawyerUpBackend.Application.Models.Lawyer
{
    public class LawyerResponseModel
    {
        public string? Name { get; set; }
        public string? Now_lic_no { get; set; }
        public string? Sex { get; set; }
        public int? Age { get; set; }
        public string? Guild_name { get; set; }
        public string? Office { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
    }
}
