namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventSuspendTweening : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0x6419F2CB;
	}
}

