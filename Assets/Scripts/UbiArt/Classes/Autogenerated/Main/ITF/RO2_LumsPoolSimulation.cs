using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumsPoolSimulation : RO2_SoftCollisionSimulation {
		[Serialize("SpawnLimit"       )] public int SpawnLimit;
		[Serialize("SpawnBySec"       )] public int SpawnBySec;
		[Serialize("MoveCoeff"        )] public float MoveCoeff;
		[Serialize("DetectionDistance")] public float DetectionDistance;
		[Serialize("SpawnLimit"       )] public bool SpawnLimit;
		[Serialize("SpawnBySec"       )] public bool SpawnBySec;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnLimit));
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MoveCoeff));
					SerializeField(s, nameof(DetectionDistance));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnLimit));
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MoveCoeff));
					SerializeField(s, nameof(DetectionDistance));
				}
			}
		}
		public override uint? ClassCRC => 0xD4561E01;
	}
}

