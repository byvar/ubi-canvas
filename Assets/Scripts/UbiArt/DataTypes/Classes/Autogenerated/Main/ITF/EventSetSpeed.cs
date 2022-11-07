namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSetSpeed : Event {
		public Vec2d speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speed = s.SerializeObject<Vec2d>(speed, name: "speed");
		}
		public override uint? ClassCRC => 0xAE569AD3;
	}
}

