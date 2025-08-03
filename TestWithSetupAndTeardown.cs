namespace demo_nunit_framework
{
    public class TestWithSetupAndTeardown
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup: This runs before each test.");
        }
        [Test]
        public void SetupAndTearDownTest()
        {
            Console.WriteLine("Test1: This is the first test.");
        }
        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Teardown: This runs after each test.");
        }
    }
}
