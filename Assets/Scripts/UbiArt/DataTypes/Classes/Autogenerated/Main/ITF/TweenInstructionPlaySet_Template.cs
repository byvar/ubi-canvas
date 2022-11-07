namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionPlaySet_Template : TweenInstruction_Template {
		public StringID set;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			set = s.SerializeObject<StringID>(set, name: "set");
		}
		public override uint? ClassCRC => 0x025C92CF;
	}
}

