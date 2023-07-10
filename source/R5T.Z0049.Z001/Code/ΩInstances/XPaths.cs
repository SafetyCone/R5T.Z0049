using System;


namespace R5T.Z0049.Z001
{
    public class XPaths : IXPaths
    {
        #region Infrastructure

        public static IXPaths Instance { get; } = new XPaths();


        private XPaths()
        {
        }

        #endregion
    }
}
