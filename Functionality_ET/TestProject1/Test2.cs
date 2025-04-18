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
    public class IntervalTestServiceTests
    {
        [TestMethod]
        public void CheckAnswer_ComparesIntervalsCorrectly()
        {
            var mockIntervalRepo = new Mock<IIntervalRepository>();
            mockIntervalRepo.Setup(r => r.GetAllIntervals()).Returns(new List<Interval>
        {
            new Interval("Perfect Fourth", 5)
        });

            var mockResultRepo = new Mock<ITestResultRepository>();
            var service = new IntervalTestService(mockIntervalRepo.Object, mockResultRepo.Object);

            service.GenerateTest(1); 
            var correctInterval = new Interval("Perfect Fourth", 5);
            var wrongInterval = new Interval("Wrong", 1);

            Assert.IsTrue(service.CheckAnswer(0, correctInterval));
            Assert.IsFalse(service.CheckAnswer(0, wrongInterval));
        }
    }
}
