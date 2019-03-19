using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_169_sub_759A50 : CSerializable {
		[Serialize("highlightTextStyle")] public uint highlightTextStyle;
		[Serialize("flagIconOffset"    )] public Vector3 flagIconOffset;
		[Serialize("costumeIconOffset" )] public Vector3 costumeIconOffset;
		[Serialize("costumeIconScale"  )] public Vector2 costumeIconScale;
		[Serialize("rankIconOffset"    )] public Vector3 rankIconOffset;
		[Serialize("checkIconOffset"   )] public Vector3 checkIconOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(highlightTextStyle));
			SerializeField(s, nameof(flagIconOffset));
			SerializeField(s, nameof(costumeIconOffset));
			SerializeField(s, nameof(costumeIconScale));
			SerializeField(s, nameof(rankIconOffset));
			SerializeField(s, nameof(checkIconOffset));
		}
		public override uint? ClassCRC => 0x5D7B614E;
	}
}

