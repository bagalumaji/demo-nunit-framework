namespace demo_nunit_framework
{
    //to run - dotnet test --filter Category=Smoke
    [TestFixture]
    public class RepeatCategoryTests
    {
        [Category("Sanity")]
        [Repeat(2)]
        [Test]
        public void Test1()
        {
            Console.WriteLine("test 1 executed...");
            Assert.Pass("Test1 executed successfully.");
        }
        // 2nd test with the same category
        [Test,Category("Smoke"),Repeat(3)]
        public void Test2()
        {
            Console.WriteLine("test 1 executed...");
            Assert.Pass("Test1 executed successfully.");
        }
        
    }
}
