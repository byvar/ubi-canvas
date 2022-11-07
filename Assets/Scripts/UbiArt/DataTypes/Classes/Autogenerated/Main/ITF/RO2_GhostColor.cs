namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GhostColor : CSerializable {
		public StringID colorConfigName;
		public Color ghostFactorColorDefault;
		public Color ghostFactorColorMin;
		public Color ghostFactorColorMax;
		public Color ghostFogColorDefault;
		public Color ghostFogColorMin;
		public Color ghostFogColorMax;
		public float ghostDistColorMin;
		public float ghostDistColorMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			colorConfigName = s.SerializeObject<StringID>(colorConfigName, name: "colorConfigName");
			ghostFactorColorDefault = s.SerializeObject<Color>(ghostFactorColorDefault, name: "ghostFactorColorDefault");
			ghostFactorColorMin = s.SerializeObject<Color>(ghostFactorColorMin, name: "ghostFactorColorMin");
			ghostFactorColorMax = s.SerializeObject<Color>(ghostFactorColorMax, name: "ghostFactorColorMax");
			ghostFogColorDefault = s.SerializeObject<Color>(ghostFogColorDefault, name: "ghostFogColorDefault");
			ghostFogColorMin = s.SerializeObject<Color>(ghostFogColorMin, name: "ghostFogColorMin");
			ghostFogColorMax = s.SerializeObject<Color>(ghostFogColorMax, name: "ghostFogColorMax");
			ghostDistColorMin = s.Serialize<float>(ghostDistColorMin, name: "ghostDistColorMin");
			ghostDistColorMax = s.Serialize<float>(ghostDistColorMax, name: "ghostDistColorMax");
		}
	}
}

