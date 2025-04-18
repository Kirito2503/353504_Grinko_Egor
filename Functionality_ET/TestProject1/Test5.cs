using TestResult = Functionality_ET.TestResult;
using Functionality_ET;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class StatisticsServiceTests
    {
        [TestMethod]
        public void CalculateSuccessRate_ReturnsCorrectPercentage()
        {
            var mockRepo = new Mock<ITestResultRepository>();
            mockRepo.Setup(r => r.GetAllResults()).Returns(new List<TestResult>
        {
            new TestResult(correct: 1, total: 2),
            new TestResult(correct: 2, total: 2)
        });

            var service = new StatisticsService(mockRepo.Object);

            double rate = service.CalculateSuccessRate();

            Assert.AreEqual(0.75, rate);
        }
    }
}
