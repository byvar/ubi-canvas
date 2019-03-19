using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlatformerCameraComponent_Template : InGameCameraComponent_Template {
		[Serialize("useEjectMargin"                 )] public int useEjectMargin;
		[Serialize("ejectMargin"                    )] public float ejectMargin;
		[Serialize("ejectMarginDetachesPlayer"      )] public int ejectMarginDetachesPlayer;
		[Serialize("ejectForce"                     )] public float ejectForce;
		[Serialize("useDeathMargin"                 )] public int useDeathMargin;
		[Serialize("deathMargin"                    )] public float deathMargin;
		[Serialize("timeOut"                        )] public float timeOut;
		[Serialize("lastOnscreenPlayerKillsEveryone")] public int lastOnscreenPlayerKillsEveryone;
		[Serialize("pursuitUseDeathMargin"          )] public int pursuitUseDeathMargin;
		[Serialize("pursuitDeathMargin"             )] public float pursuitDeathMargin;
		[Serialize("pursuitTimeOut"                 )] public float pursuitTimeOut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useEjectMargin));
			SerializeField(s, nameof(ejectMargin));
			SerializeField(s, nameof(ejectMarginDetachesPlayer));
			SerializeField(s, nameof(ejectForce));
			SerializeField(s, nameof(useDeathMargin));
			SerializeField(s, nameof(deathMargin));
			SerializeField(s, nameof(timeOut));
			SerializeField(s, nameof(lastOnscreenPlayerKillsEveryone));
			SerializeField(s, nameof(pursuitUseDeathMargin));
			SerializeField(s, nameof(pursuitDeathMargin));
			SerializeField(s, nameof(pursuitTimeOut));
		}
		public override uint? ClassCRC => 0x2A9ACB4C;
	}
}

