using System.Drawing;

namespace Citron.Extensions
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Sets the transparency of the color with a value of 50.
        /// </summary>
        public static Color Clear(this Color color)
        {
            return Color.FromArgb(50, color.R, color.G, color.B);
        }
    }
}
