namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpikyBallComponent : ActorComponent {
		public float torqueFriction = 1f;
		public float airFrictionMultiplier = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
			airFrictionMultiplier = s.Serialize<float>(airFrictionMultiplier, name: "airFrictionMultiplier");
		}
		public override uint? ClassCRC => 0x80EF4FD3;
	}
}

