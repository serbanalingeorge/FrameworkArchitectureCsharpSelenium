using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void StartTest()
        {
            Browser.Init();
        }

        [TearDown]
        public static void EndTest()
        {
            Browser.Close();
        }

    }
}
