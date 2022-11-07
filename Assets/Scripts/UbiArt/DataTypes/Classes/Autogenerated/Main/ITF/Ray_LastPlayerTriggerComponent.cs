namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LastPlayerTriggerComponent : TriggerComponent {
		public float timeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeBeforeActivation = s.Serialize<float>(timeBeforeActivation, name: "timeBeforeActivation");
		}
		public override uint? ClassCRC => 0x74794E3B;
	}
}

