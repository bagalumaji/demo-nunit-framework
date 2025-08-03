namespace demo_nunit_framework
{
    public class DataDrivenTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(4, 5, 9)]
        [Ignore("Flaky")]
        public void DemoTest(int a, int b, int c)
        {
            Console.WriteLine("first Value : {0}", a);
            Console.WriteLine("seconds value : {0}", b);
            Console.WriteLine("third value : {0}", c);
        }

        [TestCaseSource(nameof(GetTestData))]
        public void DemoTest2(string a, string b, string c)
        {
            Console.WriteLine("first Value : {0}", a);
            Console.WriteLine("seconds value : {0}", b);
            Console.WriteLine("third value : {0}", c);
        }
        static readonly object[] GetTestData =
        {
            new object[] { "A","B","C"},
            new object[] { "D","E","F"}
        };
    }
}
