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

        UpperCaseTransformer = 2,

        RevertTransformer= 3,

        RemoveItemTransformer = 4,

        ReplaceItemTransformer = 5
    }
}