using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_SoftCollisionSimulation : CSerializable {
		public bool ParticlesCanHit;
		public int GridWidth;
		public int GridHeight;
		public bool StaticCollision;
		public float Density;
		public float GroundReboudCoeff;
		public float RotationCoeff;
		public float GroundFriction;
		public float SpeedLimit_X;
		public float SpeedLimit_Y_Up;
		public float SpeedLimit_Y_Down;
		public bool AllowWorldPerturbation;
		public float PerturbationPower;
		public float VisualScaleMultiplier;
		public float SwarmRadiusPercent;
		public float SwarmNoisePercent;
		public float SwarmNoiseMoveCoeff;
		public uint DRC_MaxCatchNb;
		public float DRC_AttractionRadius;
		public float PHYSIC_OverlapCollisionCoeff;
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

