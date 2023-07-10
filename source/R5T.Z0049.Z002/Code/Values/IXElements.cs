using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
        private static Parsed.IXElements Parsed => Z002.Parsed.XElements.Instance;


        public XElement Simple => Parsed.Simple;
        public XElement SummaryWithPara => Parsed.SummaryWithPara;
        public XElement MemberWithSummaryWithPara => Parsed.MemberWithSummaryWithPara;
        public XElement Misformatted => Parsed.Misformatted;
    }
}
