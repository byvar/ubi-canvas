namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CharDiaPageViewer : ActorComponent {
		public Path Path__0;
		public Vec2d Vector2__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			Vector2__1 = s.SerializeObject<Vec2d>(Vector2__1, name: "Vector2__1");
		}
		public override uint? ClassCRC => 0xEFCC6209;
	}
}

