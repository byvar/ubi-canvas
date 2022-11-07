namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventDisableCollision : Event {
		public bool disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disable = s.Serialize<bool>(disable, name: "disable");
		}
		public override uint? ClassCRC => 0xE02F4F4A;
	}
}

