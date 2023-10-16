using TestFramework.Issues;

namespace DefaultImplementationBreaksDiscovery
{
    // This causes the tests to fail to load even though it's not being used anywhere
    internal class MockImplementation: IDefaultImplementation
    {
        // Uncommenting this does not resolve the issue
        //public DateTime Value { get; } = DateTime.MinValue;
    }
}
