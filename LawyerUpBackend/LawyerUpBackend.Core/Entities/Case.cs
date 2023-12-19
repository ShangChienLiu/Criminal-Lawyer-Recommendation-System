using LawyerUpBackend.Core.Common;
using System;
using System.Collections.Generic;

namespace LawyerUpBackend.Core.Entities
{
    public partial class Case : BaseEntity
    {
        public Case()
        {
            LawyerCaseMatches = new HashSet<LawyerCaseMatch>();
        }

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
        public string? DetailUrl { get; set; }
        public DateTime? JudgeDate { get; set; }

        public virtual ICollection<LawyerCaseMatch> LawyerCaseMatches { get; set; }
    }
}
