using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002.Parsed
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
        public XElement Simple => Instances.XElementOperator.Parse(
            Instances.XmlTexts.SingleElement);
    }
}
