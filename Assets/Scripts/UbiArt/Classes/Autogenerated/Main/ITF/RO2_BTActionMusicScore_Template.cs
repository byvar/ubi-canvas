using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionMusicScore_Template : BTAction_Template {
		public Vec3d appear3dOffset;
		public StringID animJump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			appear3dOffset = s.SerializeObject<Vec3d>(appear3dOffset, name: "appear3dOffset");
			animJump = s.SerializeObject<StringID>(animJump, name: "animJump");
		}
		public override uint? ClassCRC => 0x0E3FA395;
	}
}

