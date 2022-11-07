namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerScoreComponent_Template : ActorComponent_Template {
		public float lumTrajectorySpeed;
		public float lumReleaseSpeed;
		public ITF_ParticleGenerator_Template particleGenerator;
		public Path texture;
		public uint index;
		public float particleSize;
		public float particleMaxOffset;
		public uint particleGenerationAmplitude;
		public float particleGenerationFrequency;
		public float smoothFactor;
		public float factorSpeedRelease_1P;
		public float factorSpeedRelease_2P;
		public float factorSpeedRelease_3P;
		public float factorSpeedRelease_4P;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumTrajectorySpeed = s.Serialize<float>(lumTrajectorySpeed, name: "lumTrajectorySpeed");
			lumReleaseSpeed = s.Serialize<float>(lumReleaseSpeed, name: "lumReleaseSpeed");
			particleGenerator = s.SerializeObject<ITF_ParticleGenerator_Template>(particleGenerator, name: "particleGenerator");
			texture = s.SerializeObject<Path>(texture, name: "texture");
			index = s.Serialize<uint>(index, name: "index");
			particleSize = s.Serialize<float>(particleSize, name: "particleSize");
			particleMaxOffset = s.Serialize<float>(particleMaxOffset, name: "particleMaxOffset");
			particleGenerationAmplitude = s.Serialize<uint>(particleGenerationAmplitude, name: "particleGenerationAmplitude");
			particleGenerationFrequency = s.Serialize<float>(particleGenerationFrequency, name: "particleGenerationFrequency");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			factorSpeedRelease_1P = s.Serialize<float>(factorSpeedRelease_1P, name: "factorSpeedRelease_1P");
			factorSpeedRelease_2P = s.Serialize<float>(factorSpeedRelease_2P, name: "factorSpeedRelease_2P");
			factorSpeedRelease_3P = s.Serialize<float>(factorSpeedRelease_3P, name: "factorSpeedRelease_3P");
			factorSpeedRelease_4P = s.Serialize<float>(factorSpeedRelease_4P, name: "factorSpeedRelease_4P");
		}
		public override uint? ClassCRC => 0xEB1C4D1A;
	}
}

