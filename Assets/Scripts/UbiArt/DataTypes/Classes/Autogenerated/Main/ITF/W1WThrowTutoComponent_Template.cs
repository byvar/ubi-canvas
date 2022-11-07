namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1WThrowTutoComponent_Template : ActorComponent_Template {
		public Vec2d Vector2__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x3B2BB9CF;
	}
}

