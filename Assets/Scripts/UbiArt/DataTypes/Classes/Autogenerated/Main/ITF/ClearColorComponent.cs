namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ClearColorComponent : ActorComponent {
		public SubRenderParam_ClearColor clearColor;
		public float Weight;
		public uint Priority;
		public Color clearColor2;
		public Color clearFrontLightColor;
		public Color clearBackLightColor;
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

