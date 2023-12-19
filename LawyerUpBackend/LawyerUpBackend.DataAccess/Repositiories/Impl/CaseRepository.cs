using LawyerUpBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.DataAccess.Repositiories.Impl
{
    public class CaseRepository : BaseRepository<Case>, ICaseRepository
    {
        public CaseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
