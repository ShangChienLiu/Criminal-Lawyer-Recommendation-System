using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Dtos
{
    public class PagedSortedAndFilterInput
    {
        public PagedSortedAndFilterInput()
        {
            CurrentPage = 1;
            MaxResultCount = 10;
            
        }
        public int CurrentPage { get; set; }
        public int MaxResultCount { get; set; }
        public string? Sort{ get; set; }
        public string? FilterText { get; set; }
    }
}
