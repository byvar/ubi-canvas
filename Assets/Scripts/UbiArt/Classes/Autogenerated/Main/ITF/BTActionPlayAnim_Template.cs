using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTActionPlayAnim_Template : BTAction_Template {
		[Serialize("anim"                 )] public StringID anim;
		[Serialize("restartOnFact"        )] public StringID restartOnFact;
		[Serialize("retOnFinish"          )] public bool retOnFinish;
		[Serialize("playTime"             )] public float playTime;
		[Serialize("useAnimationRootDelta")] public bool useAnimationRootDelta;
		[Serialize("disablePhys"          )] public bool disablePhys;
		[Serialize("name"                 )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(restartOnFact));
				SerializeField(s, nameof(retOnFinish));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(restartOnFact));
				SerializeField(s, nameof(retOnFinish));
				SerializeField(s, nameof(playTime));
				SerializeField(s, nameof(useAnimationRootDelta));
				SerializeField(s, nameof(disablePhys));
			} else {
				SerializeField(s, nameof(anim));
				SerializeField(s, nameof(restartOnFact));
				SerializeField(s, nameof(retOnFinish));
				SerializeField(s, nameof(playTime));
				SerializeField(s, nameof(useAnimationRootDelta));
				SerializeField(s, nameof(disablePhys));
			}
		}
		public override uint? ClassCRC => 0xAB33BDE8;
	}
}

