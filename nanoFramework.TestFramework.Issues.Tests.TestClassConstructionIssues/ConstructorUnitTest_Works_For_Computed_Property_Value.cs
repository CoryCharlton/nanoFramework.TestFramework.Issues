using System;
using nanoFramework.TestFramework;

namespace TestClassConstructionIssues
{
    [TestClass]
    public class ConstructorUnitTest_Works_For_Computed_Property_Value
    {
        public DateTime Value => DateTime.MinValue;

        [TestMethod]
        public void UnitTest_should_pass()
        {
            Console.WriteLine($"{nameof(ConstructorUnitTest_Works_For_Computed_Property_Value)}.{nameof(UnitTest_should_pass)}");
            Console.WriteLine($"Property is {Value}");
            Assert.IsTrue(true);
        }
    }
}
