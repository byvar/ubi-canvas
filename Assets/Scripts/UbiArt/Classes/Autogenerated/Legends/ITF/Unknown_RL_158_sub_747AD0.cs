using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_158_sub_747AD0 : CSerializable {
		[Serialize("highlightTextStyle")] public uint highlightTextStyle;
		[Serialize("buttonIconOffset"  )] public Vec3d buttonIconOffset;
		[Serialize("newContentOffset"  )] public Vec3d newContentOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(highlightTextStyle));
			SerializeField(s, nameof(buttonIconOffset));
			SerializeField(s, nameof(newContentOffset));
		}
		public override uint? ClassCRC => 0x049FE29A;
	}
}

