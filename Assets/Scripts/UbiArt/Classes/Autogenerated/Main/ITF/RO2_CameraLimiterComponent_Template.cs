using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CameraLimiterComponent_Template : ActorComponent_Template {
		[Serialize("useEjectMargin"                 )] public bool useEjectMargin;
		[Serialize("ejectMargin"                    )] public Margin ejectMargin;
		[Serialize("ejectMarginDeadPlayersOnly"     )] public bool ejectMarginDeadPlayersOnly;
		[Serialize("ejectMarginDetachesPlayer"      )] public bool ejectMarginDetachesPlayer;
		[Serialize("ejectForce"                     )] public float ejectForce;
		[Serialize("useDeathMargin"                 )] public bool useDeathMargin;
		[Serialize("deathMargin"                    )] public Margin deathMargin;
		[Serialize("deathMarginWithBottomConstraint")] public float deathMarginWithBottomConstraint;
		[Serialize("ignoreConstraint"               )] public bool ignoreConstraint;
		[Serialize("timeOut"                        )] public float timeOut;
		[Serialize("lastOnscreenPlayerKillsEveryone")] public bool lastOnscreenPlayerKillsEveryone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useEjectMargin));
			SerializeField(s, nameof(ejectMargin));
			SerializeField(s, nameof(ejectMarginDeadPlayersOnly));
			SerializeField(s, nameof(ejectMarginDetachesPlayer));
			SerializeField(s, nameof(ejectForce));
			SerializeField(s, nameof(useDeathMargin));
			SerializeField(s, nameof(deathMargin));
			SerializeField(s, nameof(deathMarginWithBottomConstraint));
			SerializeField(s, nameof(ignoreConstraint));
			SerializeField(s, nameof(timeOut));
			SerializeField(s, nameof(lastOnscreenPlayerKillsEveryone));
		}
		public override uint? ClassCRC => 0x33A50127;
	}
}

