using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Population : CSerializable {
		public StringID KEY;
		public float VAL;
		public CArray<float> probability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			VAL = s.Serialize<float>(VAL, name: "VAL");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			probability = s.SerializeObject<CArray<float>>(probability, name: "probability");
		}
	}
}

