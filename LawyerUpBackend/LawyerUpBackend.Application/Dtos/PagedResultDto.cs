using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Dtos
{
    public class PagedResultDto<TEntity> : PagedSortedAndFilterInput 
    {
        public int TotalCount { get; set; }
        public int PageCount => (int)Math.Ceiling(decimal.Divide(TotalCount, MaxResultCount));
        public List<TEntity> Data { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalCount;
        public bool IsFirst => CurrentPage ==1;
        public bool IsLast => CurrentPage == TotalCount;
    }
}
