using System;

namespace TestFramework.Issues
{
    public interface IDefaultImplementation
    {
        public DateTime Value => DateTime.UtcNow;
    }
}
