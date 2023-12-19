using LawyerUpBackend.Application.Exceptions;
using LawyerUpBackend.Application.Models.PredictionModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Services.Impl
{
    public class PredictionModelService : IPredictionModelService
    {
        private readonly string _pythonPath;
        private readonly string _executePath;

        public PredictionModelService(string pythonPath,string executePath)
        {
            _executePath = executePath;
            _pythonPath = pythonPath;
        }
        async Task<PredictionModelResult> IPredictionModelService.GetPredictionAsync(PredictionModelQuery querywords)
        {
            string[] result = await Run_cmd(querywords.Query);
            if (result == null)
            {
                throw new SearchNotFoundException();
            }
            else
            {
                var predictionResult = new PredictionModelResult()
                {
                    Success = true,
                    First = result[0],
                    Second  = result[1],
                    Third = result[2]
                };
                return predictionResult;
            }
        }
        private async Task<string[]> Run_cmd(string args = "")
        {
            var result = await Task.Run(() =>
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = _pythonPath;
                start.Arguments = string.Format("{0} {1}", _executePath, args);
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        var list = result.Substring(1, result.Length - 4).Split(",", StringSplitOptions.RemoveEmptyEntries);
                        List<string> returnList = new List<string>();
                        foreach (var item in list)
                        {
                            returnList.Add(item.TrimStart().TrimEnd().Replace("'", ""));
                        }
                        return returnList.ToArray();
                    }
                }
            });
            return result;
        }
    }
}
