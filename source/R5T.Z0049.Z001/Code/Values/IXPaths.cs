using System;

using R5T.T0131;
using R5T.T0203;
using R5T.T0203.Extensions;


namespace R5T.Z0049.Z001
{
    [ValuesMarker]
    public partial interface IXPaths : IValuesMarker
    {
        public IXPathText ParaInSummary => @"/summary/para".ToXPathText();
    }
}
