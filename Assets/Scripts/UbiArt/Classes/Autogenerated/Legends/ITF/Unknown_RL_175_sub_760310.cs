using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_175_sub_760310 : CSerializable {
		[Serialize("iconTauntAnchorOffset" )] public Vec2d iconTauntAnchorOffset;
		[Serialize("iconLeaderAnchorOffset")] public Vec2d iconLeaderAnchorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(iconTauntAnchorOffset));
			SerializeField(s, nameof(iconLeaderAnchorOffset));
		}
		public override uint? ClassCRC => 0xF16C419D;
	}
}

