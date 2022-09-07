namespace devdeer.StringManipulator.Logic.Core.BaseTypes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.Interfaces;

    /// <summary>
    /// Abstract base class for all Transformers.
    /// </summary>
    public abstract class BaseTransformer : ITransformer
    {
        #region member vars

        public string CurrentMessage = string.Empty;
        public List<int> RemainingTransformations = new();

        #endregion

        #region explicit interfaces

        public void Transform(string message, List<int> transformationId)
        {
            var messageToTransform = $"The string{message} was transformed with{transformationId}";
            InternalTransformer(messageToTransform, transformationId);
        }

        #endregion

        #region methods

        /// <summary>
        /// Must be overridden by children to handle the actual Transformation task.
        /// </summary>
        /// <param name="message"> The message to be transformed</param>
        /// <param name="transformationId"> Type of transformation that has to e applied. </param>

        #region methods

        protected abstract void InternalTransformer(string message, List<int> transformationId);

        #endregion

        #endregion
    }
}