namespace File_Reader.Extensions
{
    using System;

    /// <summary>
    /// Extension methods class
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// string encryption
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>Encrypted string</returns>
        public static string ToEncryptedString(this string str)
        {
            // Simple encryption (reverse text)
            if (str == null) return null;
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
