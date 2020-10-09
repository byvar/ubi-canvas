using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionWalkToTarget_Template : BTAction_Template {
		public StringID walkAnim;
		public StringID swimAnim;
		public StringID fallAnim;
		public StringID jumpAnim;
		public StringID factTargetActor;
		public StringID factTargetPos;
		public bool canPerformTurn;
		public bool wallRun;
		public bool forceSprint;
		public bool autoJump;
		public float maxJumpHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				walkAnim = s.SerializeObject<StringID>(walkAnim, name: "walkAnim");
				swimAnim = s.SerializeObject<StringID>(swimAnim, name: "swimAnim");
				fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
				jumpAnim = s.SerializeObject<StringID>(jumpAnim, name: "jumpAnim");
				factTargetActor = s.SerializeObject<StringID>(factTargetActor, name: "factTargetActor");
				factTargetPos = s.SerializeObject<StringID>(factTargetPos, name: "factTargetPos");
				canPerformTurn = s.Serialize<bool>(canPerformTurn, name: "canPerformTurn");
				wallRun = s.Serialize<bool>(wallRun, name: "wallRun");
				forceSprint = s.Serialize<bool>(forceSprint, name: "forceSprint");
			} else {
				walkAnim = s.SerializeObject<StringID>(walkAnim, name: "walkAnim");
				swimAnim = s.SerializeObject<StringID>(swimAnim, name: "swimAnim");
				fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
				jumpAnim = s.SerializeObject<StringID>(jumpAnim, name: "jumpAnim");
				factTargetActor = s.SerializeObject<StringID>(factTargetActor, name: "factTargetActor");
				factTargetPos = s.SerializeObject<StringID>(factTargetPos, name: "factTargetPos");
				canPerformTurn = s.Serialize<bool>(canPerformTurn, name: "canPerformTurn");
				wallRun = s.Serialize<bool>(wallRun, name: "wallRun");
				forceSprint = s.Serialize<bool>(forceSprint, name: "forceSprint");
				autoJump = s.Serialize<bool>(autoJump, name: "autoJump");
				maxJumpHeight = s.Serialize<float>(maxJumpHeight, name: "maxJumpHeight");
			}
		}
		public override uint? ClassCRC => 0x981C9E5C;
	}
}

