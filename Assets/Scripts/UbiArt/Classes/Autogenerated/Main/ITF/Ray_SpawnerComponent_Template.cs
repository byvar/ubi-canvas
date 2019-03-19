using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SpawnerComponent_Template : CSerializable {
		[Serialize("actor"              )] public Path actor;
		[Serialize("numToSpawn"         )] public uint numToSpawn;
		[Serialize("ejectionForce"      )] public float ejectionForce;
		[Serialize("ejectionRandomForce")] public float ejectionRandomForce;
		[Serialize("ejectionAngle"      )] public Angle ejectionAngle;
		[Serialize("ejectionRandomAngle")] public Angle ejectionRandomAngle;
		[Serialize("ejectionFrequency"  )] public float ejectionFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actor));
			SerializeField(s, nameof(numToSpawn));
			SerializeField(s, nameof(ejectionForce));
			SerializeField(s, nameof(ejectionRandomForce));
			SerializeField(s, nameof(ejectionAngle));
			SerializeField(s, nameof(ejectionRandomAngle));
			SerializeField(s, nameof(ejectionFrequency));
		}
		public override uint? ClassCRC => 0x674A77AA;
	}
}

