using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Population : CSerializable {
		[Serialize("KEY"        )] public StringID KEY;
		[Serialize("VAL"        )] public float VAL;
		[Serialize("probability")] public CArray<float> probability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(VAL));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(probability));
		}
	}
}

