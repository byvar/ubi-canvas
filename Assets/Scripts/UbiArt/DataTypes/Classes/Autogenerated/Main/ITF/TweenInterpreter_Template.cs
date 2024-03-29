namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class TweenInterpreter_Template : CSerializable {
		public CListO<TweenInstructionSet_Template> instructionSets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			instructionSets = s.SerializeObject<CListO<TweenInstructionSet_Template>>(instructionSets, name: "instructionSets");
		}
	}
}

