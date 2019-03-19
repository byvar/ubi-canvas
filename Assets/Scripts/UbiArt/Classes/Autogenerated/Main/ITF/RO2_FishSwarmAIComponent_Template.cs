using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FishSwarmAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("widthDensity"       )] public float widthDensity;
		[Serialize("heightDensity"      )] public float heightDensity;
		[Serialize("speedMin"           )] public float speedMin;
		[Serialize("speedMax"           )] public float speedMax;
		[Serialize("radiusFree"         )] public float radiusFree;
		[Serialize("repulseForce"       )] public float repulseForce;
		[Serialize("repulseForceMax"    )] public float repulseForceMax;
		[Serialize("countSinus"         )] public uint countSinus;
		[Serialize("intensityMin"       )] public float intensityMin;
		[Serialize("intensityMax"       )] public float intensityMax;
		[Serialize("frequencyMin"       )] public float frequencyMin;
		[Serialize("frequencyMax"       )] public float frequencyMax;
		[Serialize("dephaseMin"         )] public float dephaseMin;
		[Serialize("dephaseMax"         )] public float dephaseMax;
		[Serialize("sizeWidthParticles" )] public float sizeWidthParticles;
		[Serialize("sizeHeightParticles")] public float sizeHeightParticles;
		[Serialize("scaleMin"           )] public float scaleMin;
		[Serialize("scaleMax"           )] public float scaleMax;
		[Serialize("smoothFactorMove"   )] public float smoothFactorMove;
		[Serialize("smoothFactorRotate" )] public float smoothFactorRotate;
		[Serialize("globalIntensityMin" )] public float globalIntensityMin;
		[Serialize("globalIntensityMax" )] public float globalIntensityMax;
		[Serialize("globalFrequencyMin" )] public float globalFrequencyMin;
		[Serialize("globalFrequencyMax" )] public float globalFrequencyMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(widthDensity));
			SerializeField(s, nameof(heightDensity));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(radiusFree));
			SerializeField(s, nameof(repulseForce));
			SerializeField(s, nameof(repulseForceMax));
			SerializeField(s, nameof(countSinus));
			SerializeField(s, nameof(intensityMin));
			SerializeField(s, nameof(intensityMax));
			SerializeField(s, nameof(frequencyMin));
			SerializeField(s, nameof(frequencyMax));
			SerializeField(s, nameof(dephaseMin));
			SerializeField(s, nameof(dephaseMax));
			SerializeField(s, nameof(sizeWidthParticles));
			SerializeField(s, nameof(sizeHeightParticles));
			SerializeField(s, nameof(scaleMin));
			SerializeField(s, nameof(scaleMax));
			SerializeField(s, nameof(smoothFactorMove));
			SerializeField(s, nameof(smoothFactorRotate));
			SerializeField(s, nameof(globalIntensityMin));
			SerializeField(s, nameof(globalIntensityMax));
			SerializeField(s, nameof(globalFrequencyMin));
			SerializeField(s, nameof(globalFrequencyMax));
		}
		public override uint? ClassCRC => 0xA8479776;
	}
}

