namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class SubRenderParam_Lighting : SubRenderParam {
		public Color GlobalColor;
		public Color GlobalStaticFog;
		public float GlobalFogOpacity;
		public float GlobalBrightness;
		public bool DisableLightingOnLowDevice;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GlobalColor = s.SerializeObject<Color>(GlobalColor, name: "GlobalColor");
			GlobalStaticFog = s.SerializeObject<Color>(GlobalStaticFog, name: "GlobalStaticFog");
			GlobalFogOpacity = s.Serialize<float>(GlobalFogOpacity, name: "GlobalFogOpacity");
			GlobalBrightness = s.Serialize<float>(GlobalBrightness, name: "GlobalBrightness");
			if (s.Settings.Game == Game.RM) {
				DisableLightingOnLowDevice = s.Serialize<bool>(DisableLightingOnLowDevice, name: "DisableLightingOnLowDevice");
			}
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

