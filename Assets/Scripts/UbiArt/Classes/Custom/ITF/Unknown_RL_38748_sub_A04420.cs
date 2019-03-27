using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_38748_sub_A04420 : CSerializable {
		[Serialize("moveSpeed")] public Vector2 moveSpeed;
		[Serialize("zOffset")] public float zOffset;
		[Serialize("changeEjectMargins")] public bool changeEjectMargins;
		[Serialize("ejectMarginsX")] public Vector2 ejectMarginsX;
		[Serialize("ejectMarginsY")] public Vector2 ejectMarginsY;
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