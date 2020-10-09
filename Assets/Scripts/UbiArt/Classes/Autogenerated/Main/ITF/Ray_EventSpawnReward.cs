using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventSpawnReward : Event {
		public uint numRewards;
		public int autoPickup;
		public float ejectionRandomForce;
		public Angle ejectionRandomAngle;
		public float ejectionDuration;
		public float ejectionForce;
		public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numRewards = s.Serialize<uint>(numRewards, name: "numRewards");
			autoPickup = s.Serialize<int>(autoPickup, name: "autoPickup");
			ejectionRandomForce = s.Serialize<float>(ejectionRandomForce, name: "ejectionRandomForce");
			ejectionRandomAngle = s.SerializeObject<Angle>(ejectionRandomAngle, name: "ejectionRandomAngle");
			ejectionDuration = s.Serialize<float>(ejectionDuration, name: "ejectionDuration");
			ejectionForce = s.Serialize<float>(ejectionForce, name: "ejectionForce");
			ejectionGravityAngle = s.SerializeObject<Angle>(ejectionGravityAngle, name: "ejectionGravityAngle");
		}
		public override uint? ClassCRC => 0x08ACF93F;
	}
}

