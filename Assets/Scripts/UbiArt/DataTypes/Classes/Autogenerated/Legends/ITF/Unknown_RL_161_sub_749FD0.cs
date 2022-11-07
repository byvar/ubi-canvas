namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_161_sub_749FD0 : CSerializable {
		public Placeholder pendingFriendText;
		public Placeholder addFriendText;
		public float cupPulseScale;
		public float cupPulsePeriod;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pendingFriendText = s.SerializeObject<Placeholder>(pendingFriendText, name: "pendingFriendText");
			addFriendText = s.SerializeObject<Placeholder>(addFriendText, name: "addFriendText");
			cupPulseScale = s.Serialize<float>(cupPulseScale, name: "cupPulseScale");
			cupPulsePeriod = s.Serialize<float>(cupPulsePeriod, name: "cupPulsePeriod");
		}
		public override uint? ClassCRC => 0x590A7A5D;
	}
}

