namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventLumEjection : Event {
		public Vec2d ejectionForce;
		public float ejectionDuration;
		public bool isAutoPickup;
		public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectionForce = s.SerializeObject<Vec2d>(ejectionForce, name: "ejectionForce");
			ejectionDuration = s.Serialize<float>(ejectionDuration, name: "ejectionDuration");
			isAutoPickup = s.Serialize<bool>(isAutoPickup, name: "isAutoPickup");
			ejectionGravityAngle = s.SerializeObject<Angle>(ejectionGravityAngle, name: "ejectionGravityAngle");
		}
		public override uint? ClassCRC => 0xABFFA970;
	}
}

