namespace devdeer.StringManipulator.Logic.Common.Enumerations
{
    using System;
    using System.Linq;

    /// <summary>
    /// contains the possible number of transformations
    /// </summary>
    [Flags]
    public enum TransformId
    {
        LowerCaseTransformer = 1,

        RevertTransformer = 2,

        UpperCaseTransformer = 3,

        RemoveItemTransformer = 4,

        ReplaceItemTransformer = 5
    }
}