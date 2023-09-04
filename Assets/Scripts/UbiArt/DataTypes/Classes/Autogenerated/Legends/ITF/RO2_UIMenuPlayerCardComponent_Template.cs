namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuPlayerCardComponent_Template : UIMenuBasic_Template {
		public SmartLocId pendingFriendText;
		public SmartLocId addFriendText;
		public float cupPulseScale;
		public float cupPulsePeriod;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pendingFriendText = s.SerializeObject<SmartLocId>(pendingFriendText, name: "pendingFriendText");
			addFriendText = s.SerializeObject<SmartLocId>(addFriendText, name: "addFriendText");
			cupPulseScale = s.Serialize<float>(cupPulseScale, name: "cupPulseScale");
			cupPulsePeriod = s.Serialize<float>(cupPulsePeriod, name: "cupPulsePeriod");
		}
		public override uint? ClassCRC => 0x590A7A5D;
	}
}

