using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class SubRenderParam_Lighting : SubRenderParam {
		public Color GlobalColor;
		public Color GlobalStaticFog;
		public float GlobalFogOpacity;
		public float GlobalBrightness;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GlobalColor = s.SerializeObject<Color>(GlobalColor, name: "GlobalColor");
			GlobalStaticFog = s.SerializeObject<Color>(GlobalStaticFog, name: "GlobalStaticFog");
			GlobalFogOpacity = s.Serialize<float>(GlobalFogOpacity, name: "GlobalFogOpacity");
			GlobalBrightness = s.Serialize<float>(GlobalBrightness, name: "GlobalBrightness");
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

