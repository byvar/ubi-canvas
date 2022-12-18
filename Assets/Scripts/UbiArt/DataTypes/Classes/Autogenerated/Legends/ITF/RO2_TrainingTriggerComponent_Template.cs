namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_TrainingTriggerComponent_Template : TriggerComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x22265C16;
	}
}

