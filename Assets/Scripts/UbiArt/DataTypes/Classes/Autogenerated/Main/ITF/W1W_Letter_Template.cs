namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Letter_Template : W1W_InteractiveGenComponent_Template {
		public float float__0;
		public float float__1;
		public bool bool__2;
		public Vec2d Vector2__3;
		public Vec2d Vector2__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
		}
		public override uint? ClassCRC => 0x59FC70E4;
	}
}

