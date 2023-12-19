using AutoMapper;
using LawyerUpBackend.Application.Models.Case;
using LawyerUpBackend.Application.Models.Lawyer;
using LawyerUpBackend.DataAccess.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Services.Impl
{
    public class CaseService : ICaseService
    {
        private readonly ICaseRepository repository;
        private readonly IMapper mapper;

        public CaseService(ICaseRepository _repository,IMapper _mapper)
        {
            this.repository = _repository;
            this.mapper = _mapper;
        }
        public async Task<CaseListResponseModel> SearchCaseListAsync(string queryString)
        {
            throw new NotImplementedException();

        }
        public async Task<CaseResponseModel> GetByIdAsync(int id)
        {
            var @case = await repository.GetFirstAsync(@case => @case.Id == id);
            CaseResponseModel response = mapper.Map<CaseResponseModel>(@case);
            if (@case.LawyerCaseMatches.Count > 0)
            {
                response.Lawyer = new List<LawyerResponseModel>();
                @case.LawyerCaseMatches.ToList().ForEach(matches =>
                {
                    response.Lawyer.Add(mapper.Map<LawyerResponseModel>(matches.Lawyer));
                });
            }
           
            return response;
        }
    }
}
