namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventStickDisable : Event {
		public bool Disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Disable = s.Serialize<bool>(Disable, name: "Disable");
		}
		public override uint? ClassCRC => 0xBB2DF121;
	}
}

