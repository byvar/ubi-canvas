using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_CameraLimiterComponent_Template : CSerializable {
		[Serialize("useEjectMargin"                 )] public bool useEjectMargin;
		[Serialize("ejectMargin"                    )] public Placeholder ejectMargin;
		[Serialize("ejectMarginDetachesPlayer"      )] public bool ejectMarginDetachesPlayer;
		[Serialize("ejectForce"                     )] public float ejectForce;
		[Serialize("useDeathMargin"                 )] public bool useDeathMargin;
		[Serialize("deathMargin"                    )] public Placeholder deathMargin;
		[Serialize("ignoreConstraint"               )] public bool ignoreConstraint;
		[Serialize("timeOut"                        )] public float timeOut;
		[Serialize("lastOnscreenPlayerKillsEveryone")] public bool lastOnscreenPlayerKillsEveryone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useEjectMargin));
			SerializeField(s, nameof(ejectMargin));
			SerializeField(s, nameof(ejectMarginDetachesPlayer));
			SerializeField(s, nameof(ejectForce));
			SerializeField(s, nameof(useDeathMargin));
			SerializeField(s, nameof(deathMargin));
			SerializeField(s, nameof(ignoreConstraint));
			SerializeField(s, nameof(timeOut));
			SerializeField(s, nameof(lastOnscreenPlayerKillsEveryone));
		}
		public override uint? ClassCRC => 0xF7DA5110;
	}
}

