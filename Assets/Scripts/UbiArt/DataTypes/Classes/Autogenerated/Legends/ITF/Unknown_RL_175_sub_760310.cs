namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_175_sub_760310 : CSerializable {
		public Vec2d iconTauntAnchorOffset;
		public Vec2d iconLeaderAnchorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			iconTauntAnchorOffset = s.SerializeObject<Vec2d>(iconTauntAnchorOffset, name: "iconTauntAnchorOffset");
			iconLeaderAnchorOffset = s.SerializeObject<Vec2d>(iconLeaderAnchorOffset, name: "iconLeaderAnchorOffset");
		}
		public override uint? ClassCRC => 0xF16C419D;
	}
}

