namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PetSimulation : RO2_SoftCollisionSimulation {
		public int SpawnBySec;
		public float MoveCoeff;
		public float FollowPlayerCoeff;
		public float PlayerRepulsionCoeff;
		public float RepulsionDistance;
		public float DetectionDistance;
		public float TimeToReact;
		public float TimeToStartFollowing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SpawnBySec = s.Serialize<int>(SpawnBySec, name: "SpawnBySec");
				MoveCoeff = s.Serialize<float>(MoveCoeff, name: "MoveCoeff");
				FollowPlayerCoeff = s.Serialize<float>(FollowPlayerCoeff, name: "FollowPlayerCoeff");
				PlayerRepulsionCoeff = s.Serialize<float>(PlayerRepulsionCoeff, name: "PlayerRepulsionCoeff");
				RepulsionDistance = s.Serialize<float>(RepulsionDistance, name: "RepulsionDistance");
				DetectionDistance = s.Serialize<float>(DetectionDistance, name: "DetectionDistance");
				TimeToReact = s.Serialize<float>(TimeToReact, name: "TimeToReact");
				TimeToStartFollowing = s.Serialize<float>(TimeToStartFollowing, name: "TimeToStartFollowing");
			}
		}
		public override uint? ClassCRC => 0x70F3D5E2;
	}
}

