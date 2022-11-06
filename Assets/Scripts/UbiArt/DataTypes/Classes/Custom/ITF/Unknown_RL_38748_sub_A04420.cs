using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_38748_sub_A04420 : CSerializable {
		public Vec2d moveSpeed;
		public float zOffset;
		public bool changeEjectMargins;
		public Vec2d ejectMarginsX;
		public Vec2d ejectMarginsY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			moveSpeed = s.SerializeObject<Vec2d>(moveSpeed, name: "moveSpeed");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			changeEjectMargins = s.Serialize<bool>(changeEjectMargins, name: "changeEjectMargins");
			if (changeEjectMargins) {
				ejectMarginsX = s.SerializeObject<Vec2d>(ejectMarginsX, name: "ejectMarginsX");
				ejectMarginsY = s.SerializeObject<Vec2d>(ejectMarginsY, name: "ejectMarginsY");
			}
		}
	}
}
