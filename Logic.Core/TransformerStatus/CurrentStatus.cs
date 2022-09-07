namespace devdeer.StringManipulator.Logic.Core.TransformerStatus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Interfaces;

    public class CurrentStatus : ITransformer
    {
        #region explicit interfaces

        public void Transform(string message, List<int> transformationId)
        {
            while (transformationId != null)
            {
                if (transformationId[0] == 1)
                {
                    //point to lower case
                    //DELETE THE first ELEMENT IN THE LIST
                }
                if (transformationId[0] == 2)
                {
                    
                }
                if (transformationId[0] == 3)
                {
                    
                }
                if (transformationId[0] == 4)
                {
                    
                }
                if (transformationId[0] == 5)
                {
                    
                }
            }
        }

        #endregion
    }
}