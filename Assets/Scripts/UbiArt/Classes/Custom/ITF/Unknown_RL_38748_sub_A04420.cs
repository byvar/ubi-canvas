using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_38748_sub_A04420 : CSerializable {
		[Serialize("moveSpeed")] public Vec2d moveSpeed;
		[Serialize("zOffset")] public float zOffset;
		[Serialize("changeEjectMargins")] public bool changeEjectMargins;
		[Serialize("ejectMarginsX")] public Vec2d ejectMarginsX;
		[Serialize("ejectMarginsY")] public Vec2d ejectMarginsY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(moveSpeed));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(changeEjectMargins));
			if (changeEjectMargins) {
				SerializeField(s, nameof(ejectMarginsX));
				SerializeField(s, nameof(ejectMarginsY));
			}
		}
	}
}