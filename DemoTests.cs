namespace demo_nunit_framework
{
    public class DemoTests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("one time setup executed...");
        }
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("setup executed...");
        }

        [Test]
        public void demo1Test()
        {
            Console.WriteLine("demo test 1 executed...");
        }
        [Test]
        public void demo2Test()
        {
            Console.WriteLine("demo test 2 executed...");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("teardown executed...");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("one time teardown executed...");
        }
    }
}
