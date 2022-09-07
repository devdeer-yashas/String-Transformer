namespace devdeer.StringManipulator.Logic.Transformer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Core.BaseTypes;

    public class RevertItemTransformer : BaseTransformer
    {
        #region methods

        protected override void InternalTransformer(string message, List<int> transformationId)
        {
            CurrentMessage = (string)message.Reverse();
            transformationId.Remove(0);
        }

        #endregion
    }
}