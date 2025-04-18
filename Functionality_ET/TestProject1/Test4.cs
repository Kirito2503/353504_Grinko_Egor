using TestResult = Functionality_ET.TestResult;
using Functionality_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class TestResultRepositoryTests
    {
        [TestMethod]
        public void AddResult_SavesResultCorrectly()
        {
            var repo = new InMemoryTestResultRepository();
            var testResult = new TestResult(correct: 3, total: 5);

            repo.AddResult(testResult);
            var savedResults = repo.GetAllResults().ToList();

            Assert.AreEqual(1, savedResults.Count);
            Assert.AreEqual(3, savedResults[0].CorrectAnswers);
        }
    }
}
