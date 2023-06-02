using System;


namespace R5T.Z0049.Z002.Parsed
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
