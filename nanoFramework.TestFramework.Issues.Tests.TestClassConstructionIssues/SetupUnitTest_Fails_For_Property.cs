using System;
using nanoFramework.TestFramework;

namespace TestClassConstructionIssues
{
    [TestClass]
    public class SetupUnitTest_Fails_For_Property
    {
        private int Property { get; set; }

        [Setup]
        public void Setup()
        {
            Console.WriteLine($"{nameof(SetupUnitTest_Fails_For_Property)}.{nameof(Setup)}");

            Property = 1;
        }

        [TestMethod]
        public void UnitTest_should_pass()
        {
            Console.WriteLine($"{nameof(SetupUnitTest_Fails_For_Property)}.{nameof(UnitTest_should_pass)}");
            Console.WriteLine($"Property is {Property}");
            Assert.IsTrue(true);
        }
    }
}
