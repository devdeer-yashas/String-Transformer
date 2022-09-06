namespace devdeer.StringManipulator.Logic.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Must be implemented by all Transformers
    /// </summary>
    public interface ITransformer
    {
        void Transform(string message, List<int> transformationId);
    }
}