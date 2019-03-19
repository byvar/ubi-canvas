using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterPerturbationComponent_Template : CSerializable {
		[Serialize("fxFile"             )] public Path fxFile;
		[Serialize("noiseAmplitudeX"    )] public float noiseAmplitudeX;
		[Serialize("noiseFrequencyX"    )] public float noiseFrequencyX;
		[Serialize("noisePersistenceX"  )] public float noisePersistenceX;
		[Serialize("noiseNbOctaveX"     )] public uint noiseNbOctaveX;
		[Serialize("noiseAmplitudeY"    )] public float noiseAmplitudeY;
		[Serialize("noiseFrequencyY"    )] public float noiseFrequencyY;
		[Serialize("noisePersistenceY"  )] public float noisePersistenceY;
		[Serialize("noiseNbOctaveY"     )] public uint noiseNbOctaveY;
		[Serialize("noiseTimeMultiplier")] public float noiseTimeMultiplier;
		[Serialize("radius"             )] public float radius;
		[Serialize("waterMultiplier"    )] public float waterMultiplier;
		[Serialize("weight"             )] public float weight;
		[Serialize("queryPosition"      )] public int queryPosition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxFile));
			SerializeField(s, nameof(noiseAmplitudeX));
			SerializeField(s, nameof(noiseFrequencyX));
			SerializeField(s, nameof(noisePersistenceX));
			SerializeField(s, nameof(noiseNbOctaveX));
			SerializeField(s, nameof(noiseAmplitudeY));
			SerializeField(s, nameof(noiseFrequencyY));
			SerializeField(s, nameof(noisePersistenceY));
			SerializeField(s, nameof(noiseNbOctaveY));
			SerializeField(s, nameof(noiseTimeMultiplier));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(waterMultiplier));
			SerializeField(s, nameof(weight));
			SerializeField(s, nameof(queryPosition));
		}
		public override uint? ClassCRC => 0x167BF2CB;
	}
}

