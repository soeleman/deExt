namespace DeExt
{
    partial class StringExt
    {
        /// <summary>
        /// Wrapper of string.IsNullOrWhiteSpace
        /// </summary>
        /// <param name="value" cref="string"></param>
        /// <returns cref="bool"></returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}