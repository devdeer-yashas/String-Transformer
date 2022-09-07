namespace devdeer.StringManipulator.Logic.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BaseTypes;

    public class LowerCaseTransformer : BaseTransformer
    {
        #region methods

        protected override void InternalTransformer(string message, List<int> transformationId)
        {
            CurrentMessage = message.ToLower();
            transformationId.Remove(0);
        }

        #endregion
        
    }
}