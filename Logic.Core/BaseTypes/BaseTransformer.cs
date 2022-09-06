namespace devdeer.StringManipulator.Logic.Common.BaseTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    /// <summary>
    /// Abstract base class for all Transformers.
    /// </summary>

    public abstract class BaseTransformer : ITransformer
    {
        #region explicit interfaces

        public void Transform(string message, List<int> transformationId)
        {
            var messageToTransform = $"The string{message} was transformed with{transformationId}"; 
            InternalTransformer(messageToTransform, transformationId);
        }

        #endregion
/// <summary>
///  Must be overridden by children to handle the actual Transformation task.
/// </summary>
/// <param name="message"> The message to be transformed</param>
/// <param name="transformationId"> Type of transformation that has to e applied. </param>
        #region methods

        protected abstract void InternalTransformer(string message, List<int> transformationId);

        #endregion
    }
}