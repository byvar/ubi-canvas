namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterSpawnerModifierComponent_Template : CSerializable {
		public Placeholder tweenInstructionSetList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tweenInstructionSetList = s.SerializeObject<Placeholder>(tweenInstructionSetList, name: "tweenInstructionSetList");
		}
		public override uint? ClassCRC => 0xB9AEB965;
	}
}

