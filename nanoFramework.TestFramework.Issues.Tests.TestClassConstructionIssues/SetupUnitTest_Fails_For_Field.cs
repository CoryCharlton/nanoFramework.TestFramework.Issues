using System;
using nanoFramework.TestFramework;

namespace TestClassConstructionIssues
{
    [TestClass]
    public class SetupUnitTest_Fails_For_Field
    {
        private DateTime _field;

        [Setup]
        public void Setup()
        {
            Console.WriteLine($"{nameof(SetupUnitTest_Fails_For_Field)}.{nameof(Setup)}");

            _field = DateTime.UtcNow;
        }

        [TestMethod]
        public void UnitTest_should_pass()
        {
            Console.WriteLine($"{nameof(SetupUnitTest_Fails_For_Field)}.{nameof(UnitTest_should_pass)}");
            Console.WriteLine($"Field is {_field}");
            Assert.IsTrue(true);
        }
    }
}
