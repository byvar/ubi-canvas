namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventSpawnReward : Event {
		public uint numRewards = 1;
		public bool autoPickup = true;
		public float ejectionRandomForce = 100f;
		public Angle ejectionRandomAngle = 0.5235988f;
		public float ejectionDuration;
		public float ejectionForce = 200f;
		public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numRewards = s.Serialize<uint>(numRewards, name: "numRewards");
			autoPickup = s.Serialize<bool>(autoPickup, name: "autoPickup");
			ejectionRandomForce = s.Serialize<float>(ejectionRandomForce, name: "ejectionRandomForce");
			ejectionRandomAngle = s.SerializeObject<Angle>(ejectionRandomAngle, name: "ejectionRandomAngle");
			ejectionDuration = s.Serialize<float>(ejectionDuration, name: "ejectionDuration");
			ejectionForce = s.Serialize<float>(ejectionForce, name: "ejectionForce");
			ejectionGravityAngle = s.SerializeObject<Angle>(ejectionGravityAngle, name: "ejectionGravityAngle");
		}
		public override uint? ClassCRC => 0xB417E1A4;
	}
}

