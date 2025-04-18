using Functionality_ET;
using Moq;

namespace TestProject1
{
    [TestClass]
    public class QuintCircleServiceTests
    {
        [TestMethod]
        public void GetTonalities_ReturnsDataFromRepository()
        {
            var mockRepo = new Mock<ITonalityRepository>();
            mockRepo.Setup(r => r.GetAllTonalities()).Returns(new List<Tonality>
        {
            new Tonality("C Major", "C-E-G", "No accidentals")
        });

            var service = new QuintCircleService(mockRepo.Object);

            var result = service.GetTonalities().ToList();

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("C Major", result[0].Name);
        }
    }
}
