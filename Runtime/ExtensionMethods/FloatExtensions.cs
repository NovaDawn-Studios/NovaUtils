namespace NovaDawnStudios.NovaUtils
{
    /// <summary>
    ///     Provides extension methods for the <see cref="float"/> built-in type.
    /// </summary>
    public static class FloatExtensions
    {
        /// <summary>
        ///     Remaps the supplied float value <paramref name="v"/> from a range starting at <paramref name="fromStart"/> to <paramref name="fromEnd"/> to a range
        ///     starting at <paramref name="toStart"/> to <paramref name="toEnd"/>.
        /// </summary>
        /// <remarks>
        ///     The value is <b>NOT</b> clamped, and if either of the end values are less than the start values, the resulting value will be a garbage result.
        /// </remarks>
        /// <param name="v">The value to remap.</param>
        /// <param name="fromStart">The start of the <i>from</i> range we're remapping from.</param>
        /// <param name="fromEnd">The end of the <i>from</i> range we're remapping from.</param>
        /// <param name="toStart">The start of the <i>to</i> range we're remapping from.</param>
        /// <param name="toEnd">The end of the <i>to</i> range we're remapping from.</param>
        /// <returns>
        ///     <paramref name="v"/> remapped from the range <paramref name="fromStart"/>-<paramref name="fromEnd"/> to the range 
        ///     <paramref name="toStart"/>-<paramref name="toEnd"/>.
        /// </returns>
        public static float Remap(this float v, float fromStart, float fromEnd, float toStart, float toEnd)
        {
            var normalized = (v - fromStart) / (fromEnd - fromStart);
            return normalized * (toEnd - toStart) + toStart;
        }
    }
}