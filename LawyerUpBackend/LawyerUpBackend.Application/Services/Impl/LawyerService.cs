using AutoMapper;
using LawyerUpBackend.Application.Dtos;
using LawyerUpBackend.Application.Exceptions;
using LawyerUpBackend.Application.Models.Lawyer;
using LawyerUpBackend.Core.Entities;
using LawyerUpBackend.DataAccess.Repositiories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Services.Impl
{
    public class LawyerService : ILawyerService
    {
        private readonly ILawyerRepostiory _repository;
        private readonly IMapper _mapper;

        public LawyerService(ILawyerRepostiory repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LawyerListResponseModel>> GetAllAsync()
        {
            var lawyerList = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<LawyerListResponseModel>>(lawyerList);
        }

        public async Task<LawyerResponseModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var lawyer = await _repository.GetFirstAsync(lawyer => lawyer.UniqueId == id);
            return _mapper.Map<LawyerResponseModel>(lawyer);
        }

        public async Task<PagedResultDto<LawyerListResponseModel>> GetListByQuery(LawyerListQueryModel input)
        {
            var query = _repository.GetAll();
            if (string.IsNullOrEmpty(input.Name) == false)
            {
                query = query.Where(x => x.Name.Contains(input.Name));
            }
            if (string.IsNullOrEmpty(input.Sex) == false)
            {
                string sex_zh = input.Sex == "male" ? "男" : "女";
                query = query.Where(i => i.Sex.Contains(input.Sex));
            }
            var count = await query.CountAsync();
            if (count == 0)
            {
                throw new SearchNotFoundException();
            }
            ApplySort(ref query, input.Sort);
            query = query.Skip((input.CurrentPage - 1) * input.MaxResultCount).Take(input.MaxResultCount);
            var result = await query.AsNoTracking().ToListAsync();
            var returnValue = new PagedResultDto<LawyerListResponseModel>()
            {
                CurrentPage = input.CurrentPage,
                TotalCount = count,
                MaxResultCount = input.MaxResultCount,
                Data = _mapper.Map<List<LawyerListResponseModel>>(result),
                FilterText = input.FilterText,
                Sort = input.Sort,
            };
            return returnValue;
        }
        private void ApplySort(ref IQueryable<Lawyer> lawyers, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                lawyers = lawyers.OrderBy(x => x.Name);
                return;
            }

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Lawyer).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var sortingOrder = param.EndsWith(" desc") ? "descending" : "ascending";

                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {sortingOrder}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            if (string.IsNullOrWhiteSpace(orderQuery))
            {
                lawyers = lawyers.OrderBy(x => x.Name);
                return;
            }

            lawyers = lawyers.OrderBy(orderQuery);
        }
    }

}
