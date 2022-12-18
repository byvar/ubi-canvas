namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BoulderAIComponent : RO2_FruitAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF8B7B212;
	}
}

