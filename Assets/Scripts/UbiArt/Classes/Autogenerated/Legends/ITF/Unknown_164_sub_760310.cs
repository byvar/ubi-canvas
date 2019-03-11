using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_164_sub_760310 : CSerializable {
		[Serialize("iconTauntAnchorOffset" )] public Vector2 iconTauntAnchorOffset;
		[Serialize("iconLeaderAnchorOffset")] public Vector2 iconLeaderAnchorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(iconTauntAnchorOffset));
			SerializeField(s, nameof(iconLeaderAnchorOffset));
		}
		public override uint? ClassCRC => 0xF16C419D;
	}
}

