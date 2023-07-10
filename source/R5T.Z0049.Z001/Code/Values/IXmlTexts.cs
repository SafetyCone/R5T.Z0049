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

        public IXmlText SummaryAndRemarks =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks>
".Trim().ToXmlText();

        public IXmlText SummaryWithPara =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
".Trim().ToXmlText();

        public IXmlText MemberWithSummaryWithPara =>
@"
<member name=""T:R5T.T0211.ICElement"">
    <summary>
    Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
    <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
    </summary>
</member>
".Trim().ToXmlText();

        public IXmlText Misformatted =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para></summary>
".Trim().ToXmlText();
    }
}
