using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_EnduranceRule_Template : CSerializable {
		public float distanceOffset;
		public float distanceRepeat;
		public CListO<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceOffset = s.Serialize<float>(distanceOffset, name: "distanceOffset");
			distanceRepeat = s.Serialize<float>(distanceRepeat, name: "distanceRepeat");
			tags = s.SerializeObject<CListO<StringID>>(tags, name: "tags");
		}
	}
}

