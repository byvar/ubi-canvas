using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DarkCreatureSpawnComponent : ActorComponent {
		public int SpawnBySec;
		public int MaxNumber;
		public bool IsDirectional;
		public float OpeningAngle;
		public float SpawnForce;
		public bool ImmediateStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SpawnBySec = s.Serialize<int>(SpawnBySec, name: "SpawnBySec");
				MaxNumber = s.Serialize<int>(MaxNumber, name: "MaxNumber");
				IsDirectional = s.Serialize<bool>(IsDirectional, name: "IsDirectional");
				OpeningAngle = s.Serialize<float>(OpeningAngle, name: "OpeningAngle");
				SpawnForce = s.Serialize<float>(SpawnForce, name: "SpawnForce");
				ImmediateStart = s.Serialize<bool>(ImmediateStart, name: "ImmediateStart");
			}
		}
		public override uint? ClassCRC => 0x81D227C5;
	}
}

