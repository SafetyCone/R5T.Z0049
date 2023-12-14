using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Constructed.IXElements _Constructed => Constructed.XElements.Instance;
        public Parsed.IXElements _Parsed => Parsed.XElements.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public XElement ChildA => _Constructed.ChildA;

        /// <inheritdoc cref="Constructed.IXElements.Complex_OrderedChildren"/>
        public XElement Complex_OrderedChildren => _Constructed.Complex_OrderedChildren;

        public XElement MemberWithSummaryWithPara => _Parsed.MemberWithSummaryWithPara;
        public XElement Misformatted => _Parsed.Misformatted;
        public XElement Simple => _Parsed.Simple;
        public XElement SummaryWithPara => _Parsed.SummaryWithPara;

        /// <inheritdoc cref="Parsed.IXElements.WithInsignificantWhitespace"/>
        public XElement WithInsignificantWhitespace => _Parsed.WithInsignificantWhitespace;
    }
}
