namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_MusicScoreCloseEvent : CSerializable {
		public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.SerializeObject<Placeholder>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0x27A7306D;
	}
}

