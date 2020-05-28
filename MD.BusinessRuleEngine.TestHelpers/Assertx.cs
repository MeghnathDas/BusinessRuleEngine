using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MD.BusinessRuleEngine.TestHelpers
{
    public static class Assertx
    {
        /// <summary>
        /// Helper method to assert to check exception occourence
        /// </summary>
        /// <typeparam name="T">Type of exception</typeparam>
        /// <param name="a">Action to be checked</param>
        public static void DoesNotThrowException<T>(Action a) where T : Exception
        {
            try
            {
                a();
            }
            catch (T)
            {
                Assert.Fail("Expected no {0} to be thrown", typeof(T).Name);
            }
        }
    }
}
