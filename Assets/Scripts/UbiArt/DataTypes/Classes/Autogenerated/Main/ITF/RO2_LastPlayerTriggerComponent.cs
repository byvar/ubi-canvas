namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LastPlayerTriggerComponent : TriggerComponent {
		public float timeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeBeforeActivation = s.Serialize<float>(timeBeforeActivation, name: "timeBeforeActivation");
		}
		public override uint? ClassCRC => 0x2ABCD46D;
	}
}

