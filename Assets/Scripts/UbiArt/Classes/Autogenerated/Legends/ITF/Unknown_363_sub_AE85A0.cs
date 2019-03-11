using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_363_sub_AE85A0 : CSerializable {
		[Serialize("firstBounceDirection")] public float firstBounceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(firstBounceDirection));
		}
		public override uint? ClassCRC => 0x2FBC5781;
	}
}

