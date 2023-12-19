using LawyerUpBackend.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Core.Entities
{
    public class Lawyer : BaseEntity
    {
        public Lawyer()
        {
            LawyerCaseMatches = new HashSet<LawyerCaseMatch>();
        }
        public Guid? UniqueId { get; set; }
        [Column("lawyer_name")]
        public string? Name { get; set; }
        [Column("now_lic_no")]
        public string? Now_lic_no { get; set; }
        [Column("sex")]
        public string? Sex { get; set; }
        [Column("birthyear")]
        public int? Birthyear { get; set; }
        [Column("guild_name")]
        public string? Guild_name { get; set; }
        [Column("office")]
        public string? Office { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("tel")]
        public string? Tel { get; set; }
        [Column("addr")]
        public string? Address { get; set; }
        public virtual ICollection<LawyerCaseMatch> LawyerCaseMatches { get; set; }

    }
}
