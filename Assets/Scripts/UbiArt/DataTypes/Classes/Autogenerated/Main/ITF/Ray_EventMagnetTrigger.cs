namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventMagnetTrigger : EventTrigger {
		public float magnetForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			magnetForce = s.Serialize<float>(magnetForce, name: "magnetForce");
		}
		public override uint? ClassCRC => 0x0660A7C6;
	}
}

