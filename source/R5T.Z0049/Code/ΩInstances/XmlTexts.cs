using System;


namespace R5T.Z0049
{
    public class XmlTexts : IXmlTexts
    {
        #region Infrastructure

        public static IXmlTexts Instance { get; } = new XmlTexts();


        private XmlTexts()
        {
        }

        #endregion
    }
}
