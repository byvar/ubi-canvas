namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MaskResolverComponent : ActorComponent {
		public bool clearFrontLightBuffer = true;
		public Color clearFrontLightColor = Color.Grey;
		public bool clearBackLightBuffer = true;
		public Color clearBackLightColor = Color.Black;
		public float blurSize = 6f;
		public int blurFrontLightBuffer;
		public int blurBackLightBuffer;
		public uint blurQuality = 1;
		public uint blurSize2 = 8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
				clearFrontLightBuffer = s.Serialize<bool>(clearFrontLightBuffer, name: "clearFrontLightBuffer");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightBuffer = s.Serialize<bool>(clearBackLightBuffer, name: "clearBackLightBuffer");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
				blurFrontLightBuffer = s.Serialize<int>(blurFrontLightBuffer, name: "blurFrontLightBuffer");
				blurBackLightBuffer = s.Serialize<int>(blurBackLightBuffer, name: "blurBackLightBuffer");
				blurQuality = s.Serialize<uint>(blurQuality, name: "blurQuality");
				blurSize2 = s.Serialize<uint>(blurSize2, name: "blurSize");
			} else {
				clearFrontLightBuffer = s.Serialize<bool>(clearFrontLightBuffer, name: "clearFrontLightBuffer");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightBuffer = s.Serialize<bool>(clearBackLightBuffer, name: "clearBackLightBuffer");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
				blurSize = s.Serialize<float>(blurSize, name: "blurSize");
			}
		}
		public override uint? ClassCRC => 0x93D66A6E;
	}
}

