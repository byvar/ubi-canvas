namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_SoftCollisionSimulation : CSerializable {
		public bool ParticlesCanHit;
		public int GridWidth = 20;
		public int GridHeight = 10;
		public bool StaticCollision = true;
		public float Density = 50f;
		public float GroundReboudCoeff;
		public float RotationCoeff;
		public float GroundFriction;
		public float SpeedLimit_X = 10f;
		public float SpeedLimit_Y_Up = 10f;
		public float SpeedLimit_Y_Down = 25f;
		public bool AllowWorldPerturbation;
		public float PerturbationPower = 15f;
		public float VisualScaleMultiplier = 1f;
		public float SwarmRadiusPercent = 0.5f;
		public float SwarmNoisePercent = 0.05f;
		public float SwarmNoiseMoveCoeff = 10f;
		public uint DRC_MaxCatchNb = 30;
		public float DRC_AttractionRadius = 2f;
		public float PHYSIC_OverlapCollisionCoeff = 0.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				ParticlesCanHit = s.Serialize<bool>(ParticlesCanHit, name: "ParticlesCanHit");
				GridWidth = s.Serialize<int>(GridWidth, name: "GridWidth");
				GridHeight = s.Serialize<int>(GridHeight, name: "GridHeight");
				StaticCollision = s.Serialize<bool>(StaticCollision, name: "StaticCollision");
				Density = s.Serialize<float>(Density, name: "Density");
				GroundReboudCoeff = s.Serialize<float>(GroundReboudCoeff, name: "GroundReboudCoeff");
				RotationCoeff = s.Serialize<float>(RotationCoeff, name: "RotationCoeff");
				GroundFriction = s.Serialize<float>(GroundFriction, name: "GroundFriction");
				SpeedLimit_X = s.Serialize<float>(SpeedLimit_X, name: "SpeedLimit_X");
				SpeedLimit_Y_Up = s.Serialize<float>(SpeedLimit_Y_Up, name: "SpeedLimit_Y_Up");
				SpeedLimit_Y_Down = s.Serialize<float>(SpeedLimit_Y_Down, name: "SpeedLimit_Y_Down");
				AllowWorldPerturbation = s.Serialize<bool>(AllowWorldPerturbation, name: "AllowWorldPerturbation");
				PerturbationPower = s.Serialize<float>(PerturbationPower, name: "PerturbationPower");
				VisualScaleMultiplier = s.Serialize<float>(VisualScaleMultiplier, name: "VisualScaleMultiplier");
				SwarmRadiusPercent = s.Serialize<float>(SwarmRadiusPercent, name: "SwarmRadiusPercent");
				SwarmNoisePercent = s.Serialize<float>(SwarmNoisePercent, name: "SwarmNoisePercent");
				SwarmNoiseMoveCoeff = s.Serialize<float>(SwarmNoiseMoveCoeff, name: "SwarmNoiseMoveCoeff");
				DRC_MaxCatchNb = s.Serialize<uint>(DRC_MaxCatchNb, name: "DRC_MaxCatchNb");
				DRC_AttractionRadius = s.Serialize<float>(DRC_AttractionRadius, name: "DRC_AttractionRadius");
				PHYSIC_OverlapCollisionCoeff = s.Serialize<float>(PHYSIC_OverlapCollisionCoeff, name: "PHYSIC_OverlapCollisionCoeff");
			}
		}
		public override uint? ClassCRC => 0x801D0639;
	}
}

