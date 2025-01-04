namespace DeExt
{
    partial class MathExt
    {
        /// <summary>
        /// Wrapper of Math.Pow
        /// </summary>
        /// <param name="value" cref="double"></param>
        /// <param name="exponent" cref="double"></param>
        /// <returns cref="double"></returns>
        public static double Pow(
            this double value,
            double exponent)
        {
            return Math.Pow(value, exponent);
        }

        /// <summary>
        /// Wrapper of MathF.Pow
        /// </summary>
        /// <param name="value" cref="float"></param>
        /// <param name="exponent" cref="float"></param>
        /// <returns cref="float"></returns>
        public static float Pow(
            this float value,
            float exponent)
        {
            return MathF.Pow(value, exponent);
        }
    }
}