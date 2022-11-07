namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ExecuteLUA_evtTemplate : SequenceEvent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDFBACD84;
	}
}

