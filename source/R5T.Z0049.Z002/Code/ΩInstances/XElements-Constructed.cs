using System;


namespace R5T.Z0049.Z002.Constructed
{
    public class XElements : IXElements
    {
        #region Infrastructure

        public static IXElements Instance { get; } = new XElements();


        private XElements()
        {
        }

        #endregion
    }
}
