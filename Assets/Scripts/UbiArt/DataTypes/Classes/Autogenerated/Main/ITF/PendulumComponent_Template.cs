namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class PendulumComponent_Template : ActorComponent_Template {
		public float pendulumLength;
		public float pendulumInitialAngle;
		public float pendulumInitialVelocity;
		public float pendulumGravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pendulumLength = s.Serialize<float>(pendulumLength, name: "pendulumLength");
			pendulumInitialAngle = s.Serialize<float>(pendulumInitialAngle, name: "pendulumInitialAngle");
			pendulumInitialVelocity = s.Serialize<float>(pendulumInitialVelocity, name: "pendulumInitialVelocity");
			pendulumGravityMultiplier = s.Serialize<float>(pendulumGravityMultiplier, name: "pendulumGravityMultiplier");
		}
		public override uint? ClassCRC => 0x71CA7C14;
	}
}

