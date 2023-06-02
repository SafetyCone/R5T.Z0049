using System;


namespace R5T.Z0049.Z001
{
    public class ElementNames : IElementNames
    {
        #region Infrastructure

        public static IElementNames Instance { get; } = new ElementNames();


        private ElementNames()
        {
        }

        #endregion
    }
}
