using System.Threading.Tasks;
using Alba;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace Sample
{
    [TestFixture]
    public class Tests
    {
        private SystemUnderTest _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SystemUnderTest(new HostBuilder());
        }
        
        [TearDown]
        public void TearDown()
        {
            _sut.Dispose();
        }

        [Test]
        public void This_force_test_runner_to_hang_forever()
        {
            Assert.Pass();
        }
    }
}