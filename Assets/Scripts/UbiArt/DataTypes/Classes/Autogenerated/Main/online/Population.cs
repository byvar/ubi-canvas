using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Population : CSerializable {
		public CMap<StringID, float> probability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			probability = s.SerializeObject<CMap<StringID, float>>(probability, name: "probability");
		}
	}
}

