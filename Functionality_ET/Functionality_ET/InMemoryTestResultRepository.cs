using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class InMemoryTestResultRepository : ITestResultRepository
    {
        private readonly List<TestResult> _results = new();

        public void AddResult(TestResult result) => _results.Add(result);
        public IEnumerable<TestResult> GetAllResults() => _results;
    }
}
