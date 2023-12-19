using LawyerUpBackend.Application.Models.Case;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Services
{
    public interface ICaseService
    {
        Task<CaseListResponseModel> SearchCaseListAsync(string query);
        Task<CaseResponseModel> GetByIdAsync(int id);
    }
}
