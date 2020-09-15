using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FishSwarmAIComponent_Template : RO2_AIComponent_Template {
		public float widthDensity;
		public float heightDensity;
		public float speedMin;
		public float speedMax;
		public float radiusFree;
		public float repulseForce;
		public float repulseForceMax;
		public uint countSinus;
		public float intensityMin;
		public float intensityMax;
		public float frequencyMin;
		public float frequencyMax;
		public float dephaseMin;
		public float dephaseMax;
		public float sizeWidthParticles;
		public float sizeHeightParticles;
		public float scaleMin;
		public float scaleMax;
		public float smoothFactorMove;
		public float smoothFactorRotate;
		public float globalIntensityMin;
		public float globalIntensityMax;
		public float globalFrequencyMin;
		public float globalFrequencyMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			widthDensity = s.Serialize<float>(widthDensity, name: "widthDensity");
			heightDensity = s.Serialize<float>(heightDensity, name: "heightDensity");
			speedMin = s.Serialize<float>(speedMin, name: "speedMin");
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			radiusFree = s.Serialize<float>(radiusFree, name: "radiusFree");
			repulseForce = s.Serialize<float>(repulseForce, name: "repulseForce");
			repulseForceMax = s.Serialize<float>(repulseForceMax, name: "repulseForceMax");
			countSinus = s.Serialize<uint>(countSinus, name: "countSinus");
			intensityMin = s.Serialize<float>(intensityMin, name: "intensityMin");
			intensityMax = s.Serialize<float>(intensityMax, name: "intensityMax");
			frequencyMin = s.Serialize<float>(frequencyMin, name: "frequencyMin");
			frequencyMax = s.Serialize<float>(frequencyMax, name: "frequencyMax");
			dephaseMin = s.Serialize<float>(dephaseMin, name: "dephaseMin");
			dephaseMax = s.Serialize<float>(dephaseMax, name: "dephaseMax");
			sizeWidthParticles = s.Serialize<float>(sizeWidthParticles, name: "sizeWidthParticles");
			sizeHeightParticles = s.Serialize<float>(sizeHeightParticles, name: "sizeHeightParticles");
			scaleMin = s.Serialize<float>(scaleMin, name: "scaleMin");
			scaleMax = s.Serialize<float>(scaleMax, name: "scaleMax");
			smoothFactorMove = s.Serialize<float>(smoothFactorMove, name: "smoothFactorMove");
			smoothFactorRotate = s.Serialize<float>(smoothFactorRotate, name: "smoothFactorRotate");
			globalIntensityMin = s.Serialize<float>(globalIntensityMin, name: "globalIntensityMin");
			globalIntensityMax = s.Serialize<float>(globalIntensityMax, name: "globalIntensityMax");
			globalFrequencyMin = s.Serialize<float>(globalFrequencyMin, name: "globalFrequencyMin");
			globalFrequencyMax = s.Serialize<float>(globalFrequencyMax, name: "globalFrequencyMax");
		}
		public override uint? ClassCRC => 0xA8479776;
	}
}

