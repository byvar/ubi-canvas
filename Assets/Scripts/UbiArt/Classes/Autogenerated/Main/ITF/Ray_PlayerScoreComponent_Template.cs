using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerScoreComponent_Template : ActorComponent_Template {
		[Serialize("lumTrajectorySpeed"         )] public float lumTrajectorySpeed;
		[Serialize("lumReleaseSpeed"            )] public float lumReleaseSpeed;
		[Serialize("particleGenerator"          )] public ITF_ParticleGenerator_Template particleGenerator;
		[Serialize("texture"                    )] public Path texture;
		[Serialize("index"                      )] public uint index;
		[Serialize("particleSize"               )] public float particleSize;
		[Serialize("particleMaxOffset"          )] public float particleMaxOffset;
		[Serialize("particleGenerationAmplitude")] public uint particleGenerationAmplitude;
		[Serialize("particleGenerationFrequency")] public float particleGenerationFrequency;
		[Serialize("smoothFactor"               )] public float smoothFactor;
		[Serialize("factorSpeedRelease_1P"      )] public float factorSpeedRelease_1P;
		[Serialize("factorSpeedRelease_2P"      )] public float factorSpeedRelease_2P;
		[Serialize("factorSpeedRelease_3P"      )] public float factorSpeedRelease_3P;
		[Serialize("factorSpeedRelease_4P"      )] public float factorSpeedRelease_4P;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumTrajectorySpeed));
			SerializeField(s, nameof(lumReleaseSpeed));
			SerializeField(s, nameof(particleGenerator));
			SerializeField(s, nameof(texture));
			SerializeField(s, nameof(index));
			SerializeField(s, nameof(particleSize));
			SerializeField(s, nameof(particleMaxOffset));
			SerializeField(s, nameof(particleGenerationAmplitude));
			SerializeField(s, nameof(particleGenerationFrequency));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(factorSpeedRelease_1P));
			SerializeField(s, nameof(factorSpeedRelease_2P));
			SerializeField(s, nameof(factorSpeedRelease_3P));
			SerializeField(s, nameof(factorSpeedRelease_4P));
		}
		public override uint? ClassCRC => 0xEB1C4D1A;
	}
}

