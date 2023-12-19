using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Models.Lawyer
{
    public class LawyerListResponseModel
    {
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? Guild_name { get; set; }
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public Guid? Id { get; set; }
    }
}
