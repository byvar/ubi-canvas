using ImageMagick;

namespace UbiCanvas.Helpers 
{
	public static class MagickHelpers 
	{
		public static byte[] ExportDDSWithMipmaps(this MagickImage img, FilterType filterType = FilterType.Box) {
			byte[] bytes = null;

			using (MagickImageCollection collection = new MagickImageCollection()) {
				img.Format = MagickFormat.Dds;
				img.Settings.SetDefine(MagickFormat.Dds, "compression", "none");
				img.Settings.SetDefine(MagickFormat.Dds, "mipmaps", "fromlist");
				//img.Settings.SetDefine(MagickFormat.Dds, "weight-by-alpha", false);
				var w = img.Width;
				var h = img.Height;
				collection.Add(img);

				using var color = new MagickImage(img);
				using var alpha = new MagickImage(img);
				color.Alpha(AlphaOption.Off);
				alpha.Alpha(AlphaOption.Extract);
				void Divide() {
					if (w > 1) w >>= 1;
					if (h > 1) h >>= 1;
				}
				Divide();

				while (w != 1 || h != 1) {
					var mip = new MagickImage(color);
					var mipAlpha = new MagickImage(alpha);
					mip.FilterType = filterType;
					mipAlpha.FilterType = filterType;
					mip.Resize(w, h);
					mipAlpha.Resize(w, h);

					mip.Composite(mipAlpha, CompositeOperator.CopyAlpha);
					collection.Add(mip);

					Divide();
				}

				bytes = collection.ToByteArray(MagickFormat.Dds);
			}
			return bytes;
		}
	}
}