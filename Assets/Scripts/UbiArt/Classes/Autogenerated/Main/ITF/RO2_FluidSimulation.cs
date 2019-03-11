using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FluidSimulation : RO2_SoftCollisionSimulationFluid {
		[Serialize("PlaySpecificFX"   )] public bool PlaySpecificFX;
		[Serialize("NbOfFXGenerator"  )] public uint NbOfFXGenerator;
		[Serialize("SpawnLimit"       )] public int SpawnLimit;
		[Serialize("SpawnBySec"       )] public int SpawnBySec;
		[Serialize("SpawnOpeningAngle")] public float SpawnOpeningAngle;
		[Serialize("SpawnForce"       )] public float SpawnForce;
		[Serialize("OutputWideness"   )] public float OutputWideness;
		[Serialize("RespawnDelay"     )] public float RespawnDelay;
		[Serialize("SpawnLimit"       )] public bool SpawnLimit;
		[Serialize("SpawnBySec"       )] public bool SpawnBySec;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PlaySpecificFX));
					SerializeField(s, nameof(NbOfFXGenerator));
					SerializeField(s, nameof(SpawnLimit));
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(SpawnOpeningAngle));
					SerializeField(s, nameof(SpawnForce));
					SerializeField(s, nameof(OutputWideness));
					SerializeField(s, nameof(RespawnDelay));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(PlaySpecificFX));
					SerializeField(s, nameof(NbOfFXGenerator));
					SerializeField(s, nameof(SpawnLimit));
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(SpawnOpeningAngle));
					SerializeField(s, nameof(SpawnForce));
					SerializeField(s, nameof(OutputWideness));
					SerializeField(s, nameof(RespawnDelay));
				}
			}
		}
		public override uint? ClassCRC => 0xFD25BBB2;
	}
}

