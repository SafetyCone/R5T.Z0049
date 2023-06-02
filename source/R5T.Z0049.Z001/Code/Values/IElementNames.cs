using System;

using R5T.L0030.T000;
using R5T.L0030.T000.Extensions;
using R5T.T0131;


namespace R5T.Z0049.Z001
{
    [ValuesMarker]
    public partial interface IElementNames : IValuesMarker
    {
        public IElementName ChildA => "ChildA".ToElementName();
        public IElementName ChildB => "ChildB".ToElementName();
        public IElementName ChildC => "ChildC".ToElementName();
        public IElementName ChildD => "ChildD".ToElementName();
        public IElementName Complex => "Complex".ToElementName();
        public IElementName Simple => "simple".ToElementName();
    }
}
