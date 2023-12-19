using LawyerUpBackend.Application.Models.PredictionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Services
{
    public interface IPredictionModelService
    {
        Task<PredictionModelResult> GetPredictionAsync(PredictionModelQuery querywords);
    }
}
