namespace demo_nunit_framework
{
    public class OrderDemoTests
    {
        // execute from cmd - donet test --filter Name=OrderDemoTests
        [Test,Order(2)]
        public void OrderDemoTest1()
        {
            Console.WriteLine("OrderDemoTest1 executed...");
        }
        [Test, Order(3)]
        public void OrderDemoTest2()
        {
            Console.WriteLine("OrderDemoTest 2 executed...");
        }
        [Test, Order(5)]
        public void OrderDemoTest3()
        {
            Console.WriteLine("OrderDemoTest 3 executed...");
        }
        [Test, Order(2)]
        public void OrderDemoTest4()
        {
            Console.WriteLine("OrderDemoTest 4 executed...");
        }
        [Test,Order(1)]
        public void OrderDemoTest5()
        {
            Console.WriteLine("OrderDemoTest 5 executed...");
        }
    }
}
