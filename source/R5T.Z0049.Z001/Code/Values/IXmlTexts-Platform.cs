using System;

using R5T.Extensions.Xml;
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

        /// <summary>
        /// <code>
        /// &lt;summary&gt;
        /// Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
        /// &lt;para&gt;https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c&lt;/para&gt;
        /// &lt;/summary&gt;
        /// &lt;remarks&gt;
        /// This is a remark.
        /// &lt;/remarks&gt;
        /// </code>
        /// </summary>
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
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// <code>
        /// &lt;member name=""T:default""&gt;
        ///     &lt;summary&gt;
        ///     Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
        ///     &lt;para&gt;https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c&lt;/para&gt;
        ///     &lt;/summary&gt;
        ///     &lt;remarks&gt;
        ///     This is a remark.
        ///     &lt;/remarks&gt;
        /// &lt;/member&gt;
        /// </code>
        /// </summary>
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
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// <code>
        /// &lt;member name=""T:default""&gt;
        ///   &lt;summary&gt;
        /// Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
        /// &lt;para&gt;https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c&lt;/para&gt;
        /// &lt;/summary&gt;
        /// &lt;remarks&gt;
        /// This is a remark.
        /// &lt;/remarks&gt;&lt;/member&gt;
        /// </code>
        /// </summary>
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
.Trim()
.StandardizeNewLines();

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
.Trim()
.StandardizeNewLines();

        public string SummaryWithPara =>
@"
<summary>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
</summary>
"
.Trim()
.StandardizeNewLines();

        public string MemberWithSummaryWithPara =>
@"
<member name=""T:R5T.T0211.ICElement"">
    <summary>
    Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
    <para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para>
    </summary>
</member>
"
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// Note the extra whitespaces (before &lt;value&gt;, and after the closing &lt;/para&gt; tag),
        /// and the closing &lt;/para&gt; and &lt;/summary&gt; tags on the same line.
        /// </summary>
        /// <remarks>
        /// Useful in testing whether an XML deserialization-serialization loop is actually preserving whitespace.
        /// </remarks>
        public string Misformatted =>
@"
<summary>
 <value>The value.</value>
Strongly-types a XElement as a a &lt;c&gt; tag in an XML documentation comment.
<para>https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags#c</para> </summary>
"
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// <code>
        /// &lt;A&gt;
        ///    &lt;B/&gt; &lt;C/&gt;
        /// &lt;/A&gt;
        /// </code>
        /// <para>Note the indentation before the &lt;B/&gt; element, and the space before the &lt;C/&gt; element.</para>
        /// <para>Note also that there is no space before the '/' in the self-closing tags B and C. The C# XML implementation will not preserve that lack of space in a round-trip de/serialization.</para>
        /// </summary>
        public string WithInsignificantWhitespace_NonRoundtripable =>
@"
<A>
    <B/> <C/>
</A>
"
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// <code>
        /// &lt;A&gt;
        ///    &lt;B/&gt; &lt;C/&gt;
        /// &lt;/A&gt;
        /// </code>
        /// <para>Note the indentation before the &lt;B/&gt; element, and the space before the &lt;C/&gt; element.</para>
        /// <para>Note also the spaces before the '/' in the self-closing tags B and C. This allows the XML text to be round-trip de/serializable by the C# XML implementation.</para>
        /// </summary>
        public string WithInsignificantWhitespace =>
@"
<A>
    <B /> <C />
</A>
"
.Trim()
.StandardizeNewLines();

        /// <summary>
        /// <code>
        /// &lt;Complex&gt;
        ///    &lt;ChildA /&gt;
        ///    &lt;ChildB /&gt;
        ///    &lt;ChildC /&gt;
        ///    &lt;ChildD /&gt;
        ///&lt;/Complex&gt;
        /// </code>
        /// </summary>
        public string Complex_OrderedChildren =>
@"
<Complex>
    <ChildA />
    <ChildB />
    <ChildC />
    <ChildD />
</Complex>
"
.Trim()
.StandardizeNewLines();
    }
}
