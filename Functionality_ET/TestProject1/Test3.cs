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
    public class TonalityRepositoryTests
    {
        [TestMethod]
        public void GetAllTonalities_ReturnsHardcodedData()
        {
            var repo = new InMemoryTonalityRepository();

            var result = repo.GetAllTonalities().ToList();

            Assert.IsTrue(result.Any());
            Assert.AreEqual("C Major", result[0].Name);
            Assert.AreEqual("G Major", result[1].Name);
        }
    }
}
