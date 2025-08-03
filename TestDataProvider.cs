namespace demo_nunit_framework
{
    public class TestDataProvider
    {
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("A", "B", "C");
            yield return new TestCaseData("D", "E", "F");
        }
    }
}
