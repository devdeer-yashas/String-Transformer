namespace devdeer.StringManipulator.Logic.Transformer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Core.BaseTypes;

    public class UpperCaseTransformer : BaseTransformer
    {
        #region methods

        /// <summary>
        /// This is to make the message in UpperCase
        /// </summary>
        /// <param name="message"> the initial string given by the user.</param>
        /// <param name="transformationId"> The different types of transformations that has to be applied.</param>
        protected override void InternalTransformer(string message, List<int> transformationId)
        {
            CurrentMessage = message.ToUpper();
            transformationId.Remove(0);
        }

        #endregion
    }
}