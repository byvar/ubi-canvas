namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventTransformQuery : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0x0A63C099;
	}
}

