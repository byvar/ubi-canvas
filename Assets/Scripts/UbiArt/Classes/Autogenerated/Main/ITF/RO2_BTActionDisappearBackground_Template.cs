using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDisappearBackground_Template : BTAction_Template {
		public StringID animAnticipBack;
		public StringID animJumpBack;
		public StringID animAnticipFore;
		public StringID animJumpFore;
		public Vec3d offsetDefaultJump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animAnticipBack = s.SerializeObject<StringID>(animAnticipBack, name: "animAnticipBack");
			animJumpBack = s.SerializeObject<StringID>(animJumpBack, name: "animJumpBack");
			animAnticipFore = s.SerializeObject<StringID>(animAnticipFore, name: "animAnticipFore");
			animJumpFore = s.SerializeObject<StringID>(animJumpFore, name: "animJumpFore");
			offsetDefaultJump = s.SerializeObject<Vec3d>(offsetDefaultJump, name: "offsetDefaultJump");
		}
		public override uint? ClassCRC => 0xEF79604C;
	}
}

