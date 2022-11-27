namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ClearColorComponent : ActorComponent {
		public SubRenderParam_ClearColor clearColor;
		public float Weight = 1f;
		public uint Priority;
		public Color clearColor2;
		public Color clearFrontLightColor = new Color(0.5f, 0.5f, 0.5f, 1f);
		public Color clearBackLightColor = Color.Black;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				clearColor2 = s.SerializeObject<Color>(clearColor2, name: "clearColor");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
			} else {
				clearColor = s.SerializeObject<SubRenderParam_ClearColor>(clearColor, name: "clearColor");
				Weight = s.Serialize<float>(Weight, name: "Weight");
				Priority = s.Serialize<uint>(Priority, name: "Priority");
			}
		}
		public override uint? ClassCRC => 0xAEBB218B;
	}
}

