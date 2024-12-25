namespace Crack_IT_System {
	public static class ThemeColor {
		public static readonly string DefaultHTMLColor = "#660033";
		public static Color PrimaryColor { get; set; }

		public static Color ChangeColorBrightness(Color color, double correctionFactor) {
			double red = color.R;
			double green = color.G;
			double blue = color.B;

			//If correction factor is less than 0 - darken color.
			if (correctionFactor < 0) {
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			//If correction factor is greater than 0 - lighten color.
			else {
				red = (255 - red) * correctionFactor + red;
				green = (255 - green) * correctionFactor + green;
				blue = (255 - blue) * correctionFactor + blue;
			}

			return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
		}
	}
}