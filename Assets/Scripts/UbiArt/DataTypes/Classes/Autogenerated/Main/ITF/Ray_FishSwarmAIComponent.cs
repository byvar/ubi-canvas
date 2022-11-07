namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FishSwarmAIComponent : Ray_BossPlantArenaAIComponent {
		public float widthZone;
		public float heightZone;
		public Color frontColor;
		public Color frontFogColor;
		public Color backColor;
		public Color backFogColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			widthZone = s.Serialize<float>(widthZone, name: "widthZone");
			heightZone = s.Serialize<float>(heightZone, name: "heightZone");
			frontColor = s.SerializeObject<Color>(frontColor, name: "frontColor");
			frontFogColor = s.SerializeObject<Color>(frontFogColor, name: "frontFogColor");
			backColor = s.SerializeObject<Color>(backColor, name: "backColor");
			backFogColor = s.SerializeObject<Color>(backFogColor, name: "backFogColor");
		}
		public override uint? ClassCRC => 0x951EF777;
	}
}

