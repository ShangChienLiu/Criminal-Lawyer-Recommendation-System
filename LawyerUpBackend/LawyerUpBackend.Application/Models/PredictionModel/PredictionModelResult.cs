using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Models.PredictionModel
{
    public class PredictionModelResult
    {
        public bool Success { get; set; }
        public string First { get; set; }
        public string Second { get; set; }
        public string Third { get; set; }
    }
}
