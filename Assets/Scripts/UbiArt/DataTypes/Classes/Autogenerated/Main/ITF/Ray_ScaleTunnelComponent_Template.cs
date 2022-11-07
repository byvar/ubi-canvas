namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ScaleTunnelComponent_Template : CSerializable {
		public Placeholder area;
		public float scale;
		public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				area = s.SerializeObject<Placeholder>(area, name: "area");
				scale = s.Serialize<float>(scale, name: "scale");
			} else {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
			}
		}
		public override uint? ClassCRC => 0x1A08EAF7;
	}
}

