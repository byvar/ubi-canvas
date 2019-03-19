using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTActionWalkToTarget_Template : BTAction_Template {
		[Serialize("walkAnim"       )] public StringID walkAnim;
		[Serialize("swimAnim"       )] public StringID swimAnim;
		[Serialize("fallAnim"       )] public StringID fallAnim;
		[Serialize("jumpAnim"       )] public StringID jumpAnim;
		[Serialize("factTargetActor")] public StringID factTargetActor;
		[Serialize("factTargetPos"  )] public StringID factTargetPos;
		[Serialize("canPerformTurn" )] public bool canPerformTurn;
		[Serialize("wallRun"        )] public bool wallRun;
		[Serialize("forceSprint"    )] public bool forceSprint;
		[Serialize("autoJump"       )] public bool autoJump;
		[Serialize("maxJumpHeight"  )] public float maxJumpHeight;
		[Serialize("name"           )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(walkAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(jumpAnim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
				SerializeField(s, nameof(canPerformTurn));
				SerializeField(s, nameof(wallRun));
				SerializeField(s, nameof(forceSprint));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(walkAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(jumpAnim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
				SerializeField(s, nameof(canPerformTurn));
				SerializeField(s, nameof(wallRun));
				SerializeField(s, nameof(forceSprint));
				SerializeField(s, nameof(autoJump));
				SerializeField(s, nameof(maxJumpHeight));
			} else {
				SerializeField(s, nameof(walkAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(jumpAnim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
				SerializeField(s, nameof(canPerformTurn));
				SerializeField(s, nameof(wallRun));
				SerializeField(s, nameof(forceSprint));
				SerializeField(s, nameof(autoJump));
				SerializeField(s, nameof(maxJumpHeight));
			}
		}
		public override uint? ClassCRC => 0x981C9E5C;
	}
}

