using System;

using R5T.T0131;


namespace R5T.Z0049.Z001.Platform
{
    /// <summary>
    /// Example element names.
    /// </summary>
    [ValuesMarker]
    public partial interface IElementNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>"ChildA"</value></para>
        /// </summary>
        public string ChildA => "ChildA";

        /// <summary>
        /// <para><value>"ChildB"</value></para>
        /// </summary>
        public string ChildB => "ChildB";

        /// <summary>
        /// <para><value>"ChildC"</value></para>
        /// </summary>
        public string ChildC => "ChildC";

        /// <summary>
        /// <para><value>"ChildD"</value></para>
        /// </summary>
        public string ChildD => "ChildD";

        /// <summary>
        /// <para><value>"Complex"</value></para>
        /// </summary>
        public string Complex => "Complex";

        /// <summary>
        /// <para><value>"simple"</value></para>
        /// </summary>
        public string Simple_Lowercase => "simple";

        /// <summary>
        /// <para><value>"Simple"</value></para>
        /// </summary>
        public string Simple_Uppercase => "Simple";

        /// <inheritdoc cref="Simple_Lowercase"/>
        public string Simple => this.Simple_Lowercase;
    }
}
