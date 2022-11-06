using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_FluidSimulationComponent : GraphicComponent {
		public FluidType fluidType;
		public uint ParticlesMaxNb;
		public RO2_FluidSimulation FluidSimulation;
		public Color downColor;
		public Color upColor;
		public float downUpLimit;
		public float upOffLimit;
		public Color flowColor;
		public float flowSize;
		public float flowFactor;
		public bool useFoam;
		public Color foamColor;
		public float perturbation;
		public bool useGlow;
		public Color glowColor;
		public float glowSize;
		public Vec2d innerSize;
		public Vec2d outerSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				ParticlesMaxNb = s.Serialize<uint>(ParticlesMaxNb, name: "ParticlesMaxNb");
				FluidSimulation = s.SerializeObject<RO2_FluidSimulation>(FluidSimulation, name: "FluidSimulation");
				downColor = s.SerializeObject<Color>(downColor, name: "downColor");
				upColor = s.SerializeObject<Color>(upColor, name: "upColor");
				downUpLimit = s.Serialize<float>(downUpLimit, name: "downUpLimit");
				upOffLimit = s.Serialize<float>(upOffLimit, name: "upOffLimit");
				flowColor = s.SerializeObject<Color>(flowColor, name: "flowColor");
				flowSize = s.Serialize<float>(flowSize, name: "flowSize");
				flowFactor = s.Serialize<float>(flowFactor, name: "flowFactor");
				useFoam = s.Serialize<bool>(useFoam, name: "useFoam");
				foamColor = s.SerializeObject<Color>(foamColor, name: "foamColor");
				perturbation = s.Serialize<float>(perturbation, name: "perturbation");
				useGlow = s.Serialize<bool>(useGlow, name: "useGlow");
				glowColor = s.SerializeObject<Color>(glowColor, name: "glowColor");
				glowSize = s.Serialize<float>(glowSize, name: "glowSize");
				innerSize = s.SerializeObject<Vec2d>(innerSize, name: "innerSize");
				outerSize = s.SerializeObject<Vec2d>(outerSize, name: "outerSize");
			} else {
				fluidType = s.Serialize<FluidType>(fluidType, name: "FluidType");
				ParticlesMaxNb = s.Serialize<uint>(ParticlesMaxNb, name: "ParticlesMaxNb");
				FluidSimulation = s.SerializeObject<RO2_FluidSimulation>(FluidSimulation, name: "FluidSimulation");
				downColor = s.SerializeObject<Color>(downColor, name: "downColor");
				upColor = s.SerializeObject<Color>(upColor, name: "upColor");
				downUpLimit = s.Serialize<float>(downUpLimit, name: "downUpLimit");
				upOffLimit = s.Serialize<float>(upOffLimit, name: "upOffLimit");
				flowColor = s.SerializeObject<Color>(flowColor, name: "flowColor");
				flowSize = s.Serialize<float>(flowSize, name: "flowSize");
				flowFactor = s.Serialize<float>(flowFactor, name: "flowFactor");
				useFoam = s.Serialize<bool>(useFoam, name: "useFoam");
				foamColor = s.SerializeObject<Color>(foamColor, name: "foamColor");
				perturbation = s.Serialize<float>(perturbation, name: "perturbation");
				useGlow = s.Serialize<bool>(useGlow, name: "useGlow");
				glowColor = s.SerializeObject<Color>(glowColor, name: "glowColor");
				glowSize = s.Serialize<float>(glowSize, name: "glowSize");
				innerSize = s.SerializeObject<Vec2d>(innerSize, name: "innerSize");
				outerSize = s.SerializeObject<Vec2d>(outerSize, name: "outerSize");
			}
		}
		public enum FluidType {
			[Serialize("FluidType_Undefined")] Undefined = 0,
			[Serialize("FluidType_Glue"     )] Glue = 1,
			[Serialize("FluidType_Water"    )] Water = 2,
			[Serialize("FluidType_Grease"   )] Grease = 3,
		}
		public override uint? ClassCRC => 0x969C209D;
	}
}

