using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformerCameraComponent_Template : InGameCameraComponent_Template {
		[Serialize("useEjectMargin"                 )] public bool useEjectMargin;
		[Serialize("ejectMargin"                    )] public float ejectMargin;
		[Serialize("ejectMarginDeadPlayersOnly"     )] public bool ejectMarginDeadPlayersOnly;
		[Serialize("ejectMarginDetachesPlayer"      )] public bool ejectMarginDetachesPlayer;
		[Serialize("ejectForce"                     )] public float ejectForce;
		[Serialize("useDeathMargin"                 )] public bool useDeathMargin;
		[Serialize("deathMargin"                    )] public float deathMargin;
		[Serialize("deathMarginWithBottomConstraint")] public float deathMarginWithBottomConstraint;
		[Serialize("timeOut"                        )] public float timeOut;
		[Serialize("lastOnscreenPlayerKillsEveryone")] public bool lastOnscreenPlayerKillsEveryone;
		[Serialize("pursuitUseDeathMargin"          )] public bool pursuitUseDeathMargin;
		[Serialize("pursuitDeathMargin"             )] public float pursuitDeathMargin;
		[Serialize("pursuitTimeOut"                 )] public float pursuitTimeOut;
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
			SerializeField(s, nameof(timeOut));
			SerializeField(s, nameof(lastOnscreenPlayerKillsEveryone));
			SerializeField(s, nameof(pursuitUseDeathMargin));
			SerializeField(s, nameof(pursuitDeathMargin));
			SerializeField(s, nameof(pursuitTimeOut));
		}
		public override uint? ClassCRC => 0x57790C7C;
	}
}

