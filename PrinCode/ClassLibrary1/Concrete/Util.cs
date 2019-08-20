using System;

namespace CsAst
{
    public static class Util
    {
        public static string DisplayVisibility(Visibility visibility)
        {
            switch (visibility)
            {
                case Visibility.Private:
                    return "";
                case Visibility.Public:
                    return "public ";
                case Visibility.Protected:
                    return "protected ";
                default:
                    throw new InvalidCastException("Invalid Visibility");
            }
        }
    }
}
