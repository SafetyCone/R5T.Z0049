using System;

using R5T.T0131;


namespace R5T.Z0049.Z001.Platform
{
    [ValuesMarker]
    public partial interface IXmlTexts : IValuesMarker
    {
        /// <summary>
        /// "&lt;single /&gt;"
        /// <para>A single element, self-closed, with a simple name, no content, and no attributes.</para>
        /// <para>XML is well-formed, with a space before the closing solidus (slash).</para>
        /// </summary>
        public string SingleElement => "<single />";

        public string SummaryAndRemarks =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks>
"
.Trim();

        public string MemberWithSummaryAndRemarks =>
@"
<member name=""T:default"">
    <summary>
    Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
    <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
    </summary>
    <remarks>
    This is a remark.
    </remarks>
</member>
"
.Trim();

        public string MemberWithSummaryAndRemarks_Misformatted =>
@"
<member name=""T:default"">
  <summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks></member>
"
.Trim();

        public string MemberWithSummaryAndRemarks_Misformatted2 =>
@"
<member name=""T:default""><summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
<remarks>
This is a remark.
</remarks></member>
"
.Trim();

        public string SummaryWithPara =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
"
.Trim();

        public string MemberWithSummaryWithPara =>
@"
<member name=""T:R5T.T0211.ICElement"">
    <summary>
    Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
    <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
    </summary>
</member>
"
.Trim();

        public string Misformatted =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para></summary>
"
.Trim();
    }
}
