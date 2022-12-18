namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterStepDamageBehavior_Template : CSerializable {
		public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stepDamageList = s.SerializeObject<Placeholder>(stepDamageList, name: "stepDamageList");
		}
		public override uint? ClassCRC => 0x8F9D3BCF;
	}
}

