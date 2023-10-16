using System;
using nanoFramework.TestFramework;

namespace TestClassConstructionIssues
{
    [TestClass]
    public class WorkingUnitTest
    {
        [Setup]
        public void Setup()
        {
            Console.WriteLine($"{nameof(WorkingUnitTest)}.{nameof(Setup)}");
        }

        [TestMethod]
        public void UnitTest_should_pass()
        {
            Console.WriteLine($"{nameof(WorkingUnitTest)}.{nameof(UnitTest_should_pass)}");

            Assert.IsTrue(true);
        }
    }
}
