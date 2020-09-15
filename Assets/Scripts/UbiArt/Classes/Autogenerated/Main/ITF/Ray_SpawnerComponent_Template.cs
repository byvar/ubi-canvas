using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SpawnerComponent_Template : CSerializable {
		public Path actor;
		public uint numToSpawn;
		public float ejectionForce;
		public float ejectionRandomForce;
		public Angle ejectionAngle;
		public Angle ejectionRandomAngle;
		public float ejectionFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actor = s.SerializeObject<Path>(actor, name: "actor");
			numToSpawn = s.Serialize<uint>(numToSpawn, name: "numToSpawn");
			ejectionForce = s.Serialize<float>(ejectionForce, name: "ejectionForce");
			ejectionRandomForce = s.Serialize<float>(ejectionRandomForce, name: "ejectionRandomForce");
			ejectionAngle = s.SerializeObject<Angle>(ejectionAngle, name: "ejectionAngle");
			ejectionRandomAngle = s.SerializeObject<Angle>(ejectionRandomAngle, name: "ejectionRandomAngle");
			ejectionFrequency = s.Serialize<float>(ejectionFrequency, name: "ejectionFrequency");
		}
		public override uint? ClassCRC => 0x674A77AA;
	}
}

