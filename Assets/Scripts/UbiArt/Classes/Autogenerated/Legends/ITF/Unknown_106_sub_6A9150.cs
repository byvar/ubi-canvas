using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_106_sub_6A9150 : CSerializable {
		[Serialize("active"     )] public bool active;
		[Serialize("offset"     )] public Vector3 offset;
		[Serialize("applyAlways")] public bool applyAlways;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(active));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(applyAlways));
		}
		public override uint? ClassCRC => 0xA8C26DDA;
	}
}

