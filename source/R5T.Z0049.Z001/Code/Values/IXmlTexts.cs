using System;

using R5T.T0131;
using R5T.T0203;
using R5T.T0203.Extensions;


namespace R5T.Z0049.Z001
{
    [ValuesMarker]
    public partial interface IXmlTexts : IValuesMarker
    {
        /// <summary>
        /// "&lt;single /&gt;"
        /// <para>A single element, self-closed, with a simple name, no content, and no attributes.</para>
        /// <para>XML is well-formed, with a space before the closing solidus (slash).</para>
        /// </summary>
        public IXmlText SingleElement => "<single />".ToXmlText();
    }
}
