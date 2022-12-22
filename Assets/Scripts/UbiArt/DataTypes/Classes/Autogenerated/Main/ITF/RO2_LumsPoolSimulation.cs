namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumsPoolSimulation : RO2_SoftCollisionSimulation {
		public int SpawnLimit = -1;
		public int SpawnBySec = 10;
		public float MoveCoeff = 10f;
		public float DetectionDistance = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SpawnLimit = s.Serialize<int>(SpawnLimit, name: "SpawnLimit");
				SpawnBySec = s.Serialize<int>(SpawnBySec, name: "SpawnBySec");
				MoveCoeff = s.Serialize<float>(MoveCoeff, name: "MoveCoeff");
				DetectionDistance = s.Serialize<float>(DetectionDistance, name: "DetectionDistance");
			}
		}
		public override uint? ClassCRC => 0xD4561E01;
	}
}

