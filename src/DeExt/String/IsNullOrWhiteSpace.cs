namespace DeExt
{
    partial class StringExt
    {
        /// <summary>
        /// Wrapper of string.IsNullOrWhiteSpace
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}