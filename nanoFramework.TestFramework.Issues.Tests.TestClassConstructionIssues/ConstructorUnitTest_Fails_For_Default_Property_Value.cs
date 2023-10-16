using System;
using nanoFramework.TestFramework;

namespace TestClassConstructionIssues
{
    [TestClass]
    public class ConstructorUnitTest_Fails_For_Default_Property_Value
    {
        public DateTime Property { get; } = DateTime.MinValue;

        [TestMethod]
        public void UnitTest_should_pass()
        {
            Console.WriteLine($"{nameof(ConstructorUnitTest_Fails_For_Default_Property_Value)}.{nameof(UnitTest_should_pass)}");
            Console.WriteLine($"Property is {Property}");
            Assert.IsTrue(true);
        }
    }
}
