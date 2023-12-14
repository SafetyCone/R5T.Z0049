using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002.Parsed
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
        /// <inheritdoc cref="Z001.IXmlTexts.Complex_OrderedChildren"/>
        public XElement Complex_OrderedChildren => Instances.XElementOperator.Parse_AsIs(
            Instances.XmlTexts.Complex_OrderedChildren);

        public XElement Simple => Instances.XElementOperator.Parse(
            Instances.XmlTexts.SingleElement);

        public XElement SummaryWithPara => Instances.XElementOperator.Parse(
            Instances.XmlTexts.SummaryWithPara);

        public XElement MemberWithSummaryWithPara => Instances.XElementOperator.Parse_AsIs(
            Instances.XmlTexts.MemberWithSummaryWithPara);

        public XElement Misformatted => Instances.XElementOperator.Parse_AsIs(
            Instances.XmlTexts.Misformatted);

        /// <inheritdoc cref="Z001.IXmlTexts.WithInsignificantWhitespace"/>
        public XElement WithInsignificantWhitespace => Instances.XElementOperator.Parse_AsIs(
            Instances.XmlTexts.WithInsignificantWhitespace);
    }
}
