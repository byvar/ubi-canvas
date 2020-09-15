using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_FluidSimulation : RO2_SoftCollisionSimulationFluid {
		public bool PlaySpecificFX;
		public uint NbOfFXGenerator;
		public int SpawnLimit;
		public int SpawnBySec;
		public float SpawnOpeningAngle;
		public float SpawnForce;
		public float OutputWideness;
		public float RespawnDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				PlaySpecificFX = s.Serialize<bool>(PlaySpecificFX, name: "PlaySpecificFX");
				NbOfFXGenerator = s.Serialize<uint>(NbOfFXGenerator, name: "NbOfFXGenerator");
				SpawnLimit = s.Serialize<int>(SpawnLimit, name: "SpawnLimit");
				SpawnBySec = s.Serialize<int>(SpawnBySec, name: "SpawnBySec");
				SpawnOpeningAngle = s.Serialize<float>(SpawnOpeningAngle, name: "SpawnOpeningAngle");
				SpawnForce = s.Serialize<float>(SpawnForce, name: "SpawnForce");
				OutputWideness = s.Serialize<float>(OutputWideness, name: "OutputWideness");
				RespawnDelay = s.Serialize<float>(RespawnDelay, name: "RespawnDelay");
			}
		}
		public override uint? ClassCRC => 0xFD25BBB2;
	}
}

