using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetSimulation : RO2_SoftCollisionSimulation {
		[Serialize("SpawnBySec"          )] public int SpawnBySec;
		[Serialize("MoveCoeff"           )] public float MoveCoeff;
		[Serialize("FollowPlayerCoeff"   )] public float FollowPlayerCoeff;
		[Serialize("PlayerRepulsionCoeff")] public float PlayerRepulsionCoeff;
		[Serialize("RepulsionDistance"   )] public float RepulsionDistance;
		[Serialize("DetectionDistance"   )] public float DetectionDistance;
		[Serialize("TimeToReact"         )] public float TimeToReact;
		[Serialize("TimeToStartFollowing")] public float TimeToStartFollowing;
		[Serialize("SpawnBySec"          )] public bool SpawnBySec;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MoveCoeff));
					SerializeField(s, nameof(FollowPlayerCoeff));
					SerializeField(s, nameof(PlayerRepulsionCoeff));
					SerializeField(s, nameof(RepulsionDistance));
					SerializeField(s, nameof(DetectionDistance));
					SerializeField(s, nameof(TimeToReact));
					SerializeField(s, nameof(TimeToStartFollowing));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MoveCoeff));
					SerializeField(s, nameof(FollowPlayerCoeff));
					SerializeField(s, nameof(PlayerRepulsionCoeff));
					SerializeField(s, nameof(RepulsionDistance));
					SerializeField(s, nameof(DetectionDistance));
					SerializeField(s, nameof(TimeToReact));
					SerializeField(s, nameof(TimeToStartFollowing));
				}
			}
		}
		public override uint? ClassCRC => 0x70F3D5E2;
	}
}

