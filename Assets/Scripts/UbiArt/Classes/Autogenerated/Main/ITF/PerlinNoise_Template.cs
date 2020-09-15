using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PerlinNoise_Template : CSerializable {
		public float frequency;
		public float persistence;
		public uint nbOctave;
		public float amplitude;
		public float timeMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frequency = s.Serialize<float>(frequency, name: "frequency");
			persistence = s.Serialize<float>(persistence, name: "persistence");
			nbOctave = s.Serialize<uint>(nbOctave, name: "nbOctave");
			amplitude = s.Serialize<float>(amplitude, name: "amplitude");
			timeMultiplier = s.Serialize<float>(timeMultiplier, name: "timeMultiplier");
		}
	}
}

