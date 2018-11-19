using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    public class TestBase
    {
        [TestFixtureSetUp]
        public static void StartTest()
        {
            Browser.Init();
        }

        [TestFixtureTearDown]
        public static void EndTest()
        {
            Browser.Close();
        }

    }
}
