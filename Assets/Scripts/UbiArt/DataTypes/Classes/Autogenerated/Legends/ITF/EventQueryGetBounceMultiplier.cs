namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class EventQueryGetBounceMultiplier : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xA9615892;
	}
}

