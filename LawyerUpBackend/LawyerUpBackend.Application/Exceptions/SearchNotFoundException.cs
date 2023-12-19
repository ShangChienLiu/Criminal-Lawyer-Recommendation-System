using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Exceptions
{
    public class SearchNotFoundException:Exception
    {
        public Uri? RequestUrl { get;set; }
        
    }
}
