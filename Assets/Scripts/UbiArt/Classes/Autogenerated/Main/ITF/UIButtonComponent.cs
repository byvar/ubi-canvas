using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIButtonComponent : CSerializable {
		public LocalisationId lineId;
		public float offset1;
		public float offset2;
		public int isExtremity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lineId = s.SerializeObject<LocalisationId>(lineId, name: "lineId");
			offset1 = s.Serialize<float>(offset1, name: "offset1");
			offset2 = s.Serialize<float>(offset2, name: "offset2");
			isExtremity = s.Serialize<int>(isExtremity, name: "isExtremity");
		}
		public override uint? ClassCRC => 0xBAF6EB02;
	}
}

