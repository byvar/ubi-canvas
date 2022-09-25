using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AFX_ColorSettingParam : CSerializable {
		public bool use;
		public float saturation;
		public float contrast;
		public float contrastScale;
		public float bright;
		public Color colorCorrection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			saturation = s.Serialize<float>(saturation, name: "saturation");
			contrast = s.Serialize<float>(contrast, name: "contrast");
			contrastScale = s.Serialize<float>(contrastScale, name: "contrastScale");
			bright = s.Serialize<float>(bright, name: "bright");
			colorCorrection = s.SerializeObject<Color>(colorCorrection, name: "colorCorrection");
		}
	}
}

