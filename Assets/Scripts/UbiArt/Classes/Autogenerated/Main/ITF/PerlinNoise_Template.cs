using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PerlinNoise_Template : CSerializable {
		[Serialize("frequency"     )] public float frequency;
		[Serialize("persistence"   )] public float persistence;
		[Serialize("nbOctave"      )] public uint nbOctave;
		[Serialize("amplitude"     )] public float amplitude;
		[Serialize("timeMultiplier")] public float timeMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frequency));
			SerializeField(s, nameof(persistence));
			SerializeField(s, nameof(nbOctave));
			SerializeField(s, nameof(amplitude));
			SerializeField(s, nameof(timeMultiplier));
		}
	}
}

