namespace demo_nunit_framework
{
    public class DataDrivenTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(4, 5, 9)]
        public void DemoTest(int a,int b,int c)
        {
            Console.WriteLine("first Value : {0}",a);
            Console.WriteLine("seconds value : {0}",b);
            Console.WriteLine("third value : {0}",c);
        }
    }
}
