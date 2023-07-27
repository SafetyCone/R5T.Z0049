using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
        private static Constructed.IXElements Constructed => Z002.Constructed.XElements.Instance;
        private static Parsed.IXElements Parsed => Z002.Parsed.XElements.Instance;


        public XElement ChildA => Constructed.ChildA;
        public XElement Complex_OrderedChildren => Constructed.Complex_OrderedChildren;
        public XElement MemberWithSummaryWithPara => Parsed.MemberWithSummaryWithPara;
        public XElement Misformatted => Parsed.Misformatted;
        public XElement Simple => Parsed.Simple;
        public XElement SummaryWithPara => Parsed.SummaryWithPara;
    }
}
