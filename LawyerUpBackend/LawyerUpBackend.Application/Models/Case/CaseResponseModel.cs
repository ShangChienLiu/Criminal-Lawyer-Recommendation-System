using LawyerUpBackend.Application.Models.Lawyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Models.Case
{
    public class CaseResponseModel
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int? Year { get; set; }
        public string? Word { get; set; }
        public int? Number { get; set; }
        public string? Classification { get; set; }
        public string? CourtCode { get; set; }
        public string? BeforeMain { get; set; }
        public string? MainContent { get; set; }
        public string? FactReason { get; set; }
        public DateTime? JudgeDate { get; set; }
        public List<LawyerResponseModel>? Lawyer { get; set; } = null;
    }
}
