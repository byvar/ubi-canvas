namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GyroControlledMovementComponent : ActorComponent {
		public float maxSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
		}
		public override uint? ClassCRC => 0x2079E709;
	}
}

