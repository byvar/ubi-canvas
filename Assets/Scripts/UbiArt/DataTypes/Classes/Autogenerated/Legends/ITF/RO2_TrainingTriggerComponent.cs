namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_TrainingTriggerComponent : TriggerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA9B0EE76;
	}
}

