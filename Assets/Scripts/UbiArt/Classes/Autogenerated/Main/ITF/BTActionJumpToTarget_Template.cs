using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTActionJumpToTarget_Template : BTAction_Template {
		[Serialize("anim"              )] public StringID anim;
		[Serialize("factTargetActor"   )] public StringID factTargetActor;
		[Serialize("factTargetPos"     )] public StringID factTargetPos;
		[Serialize("followMovingTarget")] public bool followMovingTarget;
		[Serialize("usePhysicJump"     )] public bool usePhysicJump;
		[Serialize("name"              )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
				SerializeField(s, nameof(followMovingTarget));
				SerializeField(s, nameof(usePhysicJump));
			} else {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(factTargetActor));
				SerializeField(s, nameof(factTargetPos));
				SerializeField(s, nameof(followMovingTarget));
				SerializeField(s, nameof(usePhysicJump));
			}
		}
		public override uint? ClassCRC => 0x5AE94BD1;
	}
}

