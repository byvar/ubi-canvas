using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Population : CSerializable {
		public StringID KEY;
		public float VAL;
		public CArrayP<float> probability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			VAL = s.Serialize<float>(VAL, name: "VAL");
			KEY = s.SerializeObject<StringID>(KEY, name: "KEY");
			probability = s.SerializeObject<CArrayP<float>>(probability, name: "probability");
		}
	}
}

