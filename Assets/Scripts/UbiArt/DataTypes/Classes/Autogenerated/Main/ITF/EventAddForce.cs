namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventAddForce : Event {
		public Vec2d force;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			force = s.SerializeObject<Vec2d>(force, name: "force");
		}
		public override uint? ClassCRC => 0x67329674;
	}
}

