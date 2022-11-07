namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventEnableAutoFly : Event {
		public bool skipDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			skipDelay = s.Serialize<bool>(skipDelay, name: "skipDelay", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x1AB2ECAF;
	}
}

