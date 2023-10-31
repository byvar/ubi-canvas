namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL)]
	public partial class StepDamage : CSerializable {
		public int startHealth;
		public StringID hitAnim;
		public StringID defaultAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startHealth = s.Serialize<int>(startHealth, name: "startHealth");
			hitAnim = s.SerializeObject<StringID>(hitAnim, name: "hitAnim");
			defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
		}
	}
}
