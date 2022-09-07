namespace devdeer.StringManipulator.Tests.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Logic.Core.BaseTypes;

    /// <summary>
    /// A logger which can be used by unit tests.
    /// </summary>
    public class TestTransformer : BaseTransformer
    {
        #region constructors and destructors

        /// <inheritdoc />
        public TestTransformer(Action<string> testCallback)
        {
            TestCallback = testCallback;
        }

        #endregion

        #region methods

        /// <inheritdoc />
        protected override void InternalTransformer(string message, List<int> transformationId)
        {
            TestCallback(message);
        }

        #endregion

        #region properties

        private Action<string> TestCallback { get; }

        #endregion
    }
}