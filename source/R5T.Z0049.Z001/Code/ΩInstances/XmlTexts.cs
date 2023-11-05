using System;


namespace R5T.Z0049.Z001
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


namespace R5T.Z0049.Z001.Platform
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
