using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class StatisticsService
    {
        private readonly ITestResultRepository _repository;

        public StatisticsService(ITestResultRepository repository)
        {
            _repository = repository;
        }

        public double CalculateSuccessRate()
        {
            var results = _repository.GetAllResults().ToList();
            return results.Any()
                ? (double)results.Sum(r => r.CorrectAnswers) / results.Sum(r => r.TotalQuestions)
                : 0;
        }
    }
}
