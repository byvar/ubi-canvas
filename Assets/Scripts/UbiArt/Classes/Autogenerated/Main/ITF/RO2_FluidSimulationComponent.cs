using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FluidSimulationComponent : GraphicComponent {
		[Serialize("FluidType"      )] public FluidType FluidType;
		[Serialize("ParticlesMaxNb" )] public uint ParticlesMaxNb;
		[Serialize("FluidSimulation")] public RO2_FluidSimulation FluidSimulation;
		[Serialize("downColor"      )] public Color downColor;
		[Serialize("upColor"        )] public Color upColor;
		[Serialize("downUpLimit"    )] public float downUpLimit;
		[Serialize("upOffLimit"     )] public float upOffLimit;
		[Serialize("flowColor"      )] public Color flowColor;
		[Serialize("flowSize"       )] public float flowSize;
		[Serialize("flowFactor"     )] public float flowFactor;
		[Serialize("useFoam"        )] public bool useFoam;
		[Serialize("foamColor"      )] public Color foamColor;
		[Serialize("perturbation"   )] public float perturbation;
		[Serialize("useGlow"        )] public bool useGlow;
		[Serialize("glowColor"      )] public Color glowColor;
		[Serialize("glowSize"       )] public float glowSize;
		[Serialize("innerSize"      )] public Vector2 innerSize;
		[Serialize("outerSize"      )] public Vector2 outerSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(ParticlesMaxNb));
				SerializeField(s, nameof(FluidSimulation));
				SerializeField(s, nameof(downColor));
				SerializeField(s, nameof(upColor));
				SerializeField(s, nameof(downUpLimit));
				SerializeField(s, nameof(upOffLimit));
				SerializeField(s, nameof(flowColor));
				SerializeField(s, nameof(flowSize));
				SerializeField(s, nameof(flowFactor));
				SerializeField(s, nameof(useFoam));
				SerializeField(s, nameof(foamColor));
				SerializeField(s, nameof(perturbation));
				SerializeField(s, nameof(useGlow));
				SerializeField(s, nameof(glowColor));
				SerializeField(s, nameof(glowSize));
				SerializeField(s, nameof(innerSize));
				SerializeField(s, nameof(outerSize));
			} else {
				SerializeField(s, nameof(FluidType));
				SerializeField(s, nameof(ParticlesMaxNb));
				SerializeField(s, nameof(FluidSimulation));
				SerializeField(s, nameof(downColor));
				SerializeField(s, nameof(upColor));
				SerializeField(s, nameof(downUpLimit));
				SerializeField(s, nameof(upOffLimit));
				SerializeField(s, nameof(flowColor));
				SerializeField(s, nameof(flowSize));
				SerializeField(s, nameof(flowFactor));
				SerializeField(s, nameof(useFoam));
				SerializeField(s, nameof(foamColor));
				SerializeField(s, nameof(perturbation));
				SerializeField(s, nameof(useGlow));
				SerializeField(s, nameof(glowColor));
				SerializeField(s, nameof(glowSize));
				SerializeField(s, nameof(innerSize));
				SerializeField(s, nameof(outerSize));
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

