using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_EnduranceRule_Template : CSerializable {
		public float distanceOffset;
		public float distanceRepeat;
		public CList<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceOffset = s.Serialize<float>(distanceOffset, name: "distanceOffset");
			distanceRepeat = s.Serialize<float>(distanceRepeat, name: "distanceRepeat");
			tags = s.SerializeObject<CList<StringID>>(tags, name: "tags");
		}
	}
}

