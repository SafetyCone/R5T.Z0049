using System;

using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;
using R5T.T0131;


namespace R5T.Z0049.Z001
{
    /// <summary>
    /// Example element names.
    /// </summary>
    [ValuesMarker]
    public partial interface IElementNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IElementNames _Platform => Platform.ElementNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IElementNames.ChildA"/>
        public IElementName ChildA => _Platform.ChildA.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.ChildB"/>
        public IElementName ChildB => _Platform.ChildB.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.ChildC"/>
        public IElementName ChildC => _Platform.ChildC.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.ChildD"/>
        public IElementName ChildD => _Platform.ChildD.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.Complex"/>
        public IElementName Complex => _Platform.Complex.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.Simple_Lowercase"/>
        public IElementName Simple_Lowercase => _Platform.Simple_Lowercase.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.Simple_Uppercase"/>
        public IElementName Simple_Uppercase => _Platform.Simple_Uppercase.ToElementName();

        /// <inheritdoc cref="Platform.IElementNames.Simple"/>
        public IElementName Simple => _Platform.Simple.ToElementName();
    }
}
