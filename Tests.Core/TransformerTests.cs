namespace devdeer.StringManipulator.Tests.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Logic.Core.BaseTypes;

    using NUnit.Framework;

    /// <summary>
    /// Contains unit tests for the type and <see cref="BaseTransformer" />.
    /// </summary>
    public class TransformerTests
    {
        #region methods

        /// <summary>
        /// This method is called before any test method.
        /// </summary>
        [SetUp]
        public void BeforeAnyRun()
        {
        }

        /// <summary>
        /// This method is called before the first test is called once.
        /// </summary>
        [OneTimeSetUp]
        public void BeforeTestRun()
        {
        }

        /// <summary>
        /// Checks if the message actually contains the message the user sent in.
        /// </summary>
        [Test]
        public void CheckTransformerForMessageStringTest()
        {
            // arrange
            string? resultMessage = null;
            var transformer = new TestTransformer(m => resultMessage = m);            // act
            var testList = new List<int>();
            testList.Add(1);
            transformer.Transform("ThisIsATestString", testList);
            // assert
            Assert.NotNull(resultMessage);
            Assert.That(resultMessage, Contains.Substring("ThisIsATestString"));
        }

        #endregion
    }
}