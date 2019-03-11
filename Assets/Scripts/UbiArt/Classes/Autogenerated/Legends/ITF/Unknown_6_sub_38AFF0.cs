using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_6_sub_38AFF0 : CSerializable {
		[Serialize("buslist")] public Placeholder buslist;
		[Serialize("pitch"  )] public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(buslist));
			SerializeField(s, nameof(pitch));
		}
		public override uint? ClassCRC => 0xC5569A5C;
	}
}

