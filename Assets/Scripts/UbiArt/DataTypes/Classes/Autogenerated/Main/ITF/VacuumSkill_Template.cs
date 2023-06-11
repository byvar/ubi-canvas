namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
	public partial class VacuumSkill_Template : CSerializable {
		public PhysForceModifier vacuumForce_RO;
		public PhysForceModifier_Template vacuumForce_RL;
		public StringID vacuumZonePolylineName;
		public float stickDuration;
		public uint stackSize;
		public uint stackFullSize;
		public int stackLifoMode;
		public float vaccumSpeedFactor;
		public float stateStartDuration;
		public float stateStopDuration;
		public float stateLoopDuration;
		public float stateBeforeRestartDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion == Settings.EngineVersion.RL) {
				vacuumForce_RL = s.SerializeObject<PhysForceModifier_Template>(vacuumForce_RL, name: "vacuumForce");
				vacuumZonePolylineName = s.SerializeObject<StringID>(vacuumZonePolylineName, name: "vacuumZonePolylineName");
			} else {
				vacuumForce_RO = s.SerializeObject<PhysForceModifier>(vacuumForce_RO, name: "vacuumForce");
			}
			stickDuration = s.Serialize<float>(stickDuration, name: "stickDuration");
			stackSize = s.Serialize<uint>(stackSize, name: "stackSize");
			stackFullSize = s.Serialize<uint>(stackFullSize, name: "stackFullSize");
			stackLifoMode = s.Serialize<int>(stackLifoMode, name: "stackLifoMode");
			vaccumSpeedFactor = s.Serialize<float>(vaccumSpeedFactor, name: "vaccumSpeedFactor");
			stateStartDuration = s.Serialize<float>(stateStartDuration, name: "stateStartDuration");
			stateStopDuration = s.Serialize<float>(stateStopDuration, name: "stateStopDuration");
			stateLoopDuration = s.Serialize<float>(stateLoopDuration, name: "stateLoopDuration");
			stateBeforeRestartDuration = s.Serialize<float>(stateBeforeRestartDuration, name: "stateBeforeRestartDuration");
		}
	}
}

