namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventSetDirection : Event {
		public Vec2d direction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			direction = s.SerializeObject<Vec2d>(direction, name: "direction");
		}
		public override uint? ClassCRC => 0x0B2DF3EA;
	}
}

