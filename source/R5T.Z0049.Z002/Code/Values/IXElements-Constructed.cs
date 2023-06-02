using System;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.Z0049.Z002.Constructed
{
    [ValuesMarker]
    public partial interface IXElements : IValuesMarker
    {
        public XElement ChildA => Instances.XElementOperator.New(
            Instances.ElementNames.ChildA);

        public XElement ChildB => Instances.XElementOperator.New(
            Instances.ElementNames.ChildB);

        public XElement ChildC => Instances.XElementOperator.New(
            Instances.ElementNames.ChildC);

        public XElement ChildD => Instances.XElementOperator.New(
            Instances.ElementNames.ChildD);

        /// <summary>
        /// A complex element containing multiple children, with the children in alphabetical order by name.
        /// </summary>
        public XElement Complex_OrderedChildren => Instances.XElementOperator.New(
            Instances.ElementNames.Complex,
            this.ChildA,
            this.ChildB,
            this.ChildC,
            this.ChildD);

        public XElement Simple => Instances.XElementOperator.New(
            Instances.ElementNames.Simple);
    }
}
