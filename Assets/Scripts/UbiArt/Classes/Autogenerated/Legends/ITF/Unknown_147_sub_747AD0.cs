using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_147_sub_747AD0 : CSerializable {
		[Serialize("highlightTextStyle")] public uint highlightTextStyle;
		[Serialize("buttonIconOffset"  )] public Vector3 buttonIconOffset;
		[Serialize("newContentOffset"  )] public Vector3 newContentOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(highlightTextStyle));
			SerializeField(s, nameof(buttonIconOffset));
			SerializeField(s, nameof(newContentOffset));
		}
		public override uint? ClassCRC => 0x049FE29A;
	}
}

