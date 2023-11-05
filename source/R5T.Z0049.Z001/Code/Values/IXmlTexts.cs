using System;

using R5T.T0131;
using R5T.T0203;
using R5T.T0203.Extensions;


namespace R5T.Z0049.Z001
{
    [ValuesMarker]
    public partial interface IXmlTexts : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IXmlTexts _Platform => Platform.XmlTexts.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Platform.IXmlTexts.SingleElement"/>
        public IXmlText SingleElement => _Platform.SingleElement.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.SummaryAndRemarks"/>
        public IXmlText SummaryAndRemarks => _Platform.SummaryAndRemarks.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.MemberWithSummaryAndRemarks"/>
        public IXmlText MemberWithSummaryAndRemarks => _Platform.MemberWithSummaryAndRemarks.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.MemberWithSummaryAndRemarks_Misformatted"/>
        public IXmlText MemberWithSummaryAndRemarks_Misformatted => _Platform.MemberWithSummaryAndRemarks_Misformatted.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.MemberWithSummaryAndRemarks_Misformatted2"/>
        public IXmlText MemberWithSummaryAndRemarks_Misformatted2 => _Platform.MemberWithSummaryAndRemarks_Misformatted2.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.SummaryWithPara"/>
        public IXmlText SummaryWithPara => _Platform.SummaryWithPara.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.MemberWithSummaryWithPara"/>
        public IXmlText MemberWithSummaryWithPara => _Platform.MemberWithSummaryWithPara.ToXmlText();

        /// <inheritdoc cref="Platform.IXmlTexts.Misformatted"/>
        public IXmlText Misformatted => _Platform.Misformatted.ToXmlText();
    }
}
