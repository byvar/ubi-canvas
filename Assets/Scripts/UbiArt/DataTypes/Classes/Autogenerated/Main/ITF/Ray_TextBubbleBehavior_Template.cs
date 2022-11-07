namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TextBubbleBehavior_Template : CSerializable {
		public StringID textBoneName;
		public Placeholder sleepAction;
		public Placeholder openAction;
		public Placeholder idleAction;
		public Placeholder closeAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textBoneName = s.SerializeObject<StringID>(textBoneName, name: "textBoneName");
			sleepAction = s.SerializeObject<Placeholder>(sleepAction, name: "sleepAction");
			openAction = s.SerializeObject<Placeholder>(openAction, name: "openAction");
			idleAction = s.SerializeObject<Placeholder>(idleAction, name: "idleAction");
			closeAction = s.SerializeObject<Placeholder>(closeAction, name: "closeAction");
		}
		public override uint? ClassCRC => 0x11E52943;
	}
}

