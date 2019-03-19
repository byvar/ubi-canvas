using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class UIButtonComponent : CSerializable {
		[Serialize("lineId"     )] public LocalisationId lineId;
		[Serialize("offset1"    )] public float offset1;
		[Serialize("offset2"    )] public float offset2;
		[Serialize("isExtremity")] public int isExtremity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lineId));
			SerializeField(s, nameof(offset1));
			SerializeField(s, nameof(offset2));
			SerializeField(s, nameof(isExtremity));
		}
		public override uint? ClassCRC => 0xBAF6EB02;
	}
}

