namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class Label_evtTemplate : SequenceEvent_Template {
		public string Label;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Label = s.Serialize<string>(Label, name: "Label");
		}
		public override uint? ClassCRC => 0xB325916C;
	}
}

