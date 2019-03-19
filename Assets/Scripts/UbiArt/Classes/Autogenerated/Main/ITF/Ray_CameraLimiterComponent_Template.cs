using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_CameraLimiterComponent_Template : CSerializable {
		[Serialize("useEjectMargin"                 )] public int useEjectMargin;
		[Serialize("ejectMargin"                    )] public Margin ejectMargin;
		[Serialize("ejectMarginDetachesPlayer"      )] public int ejectMarginDetachesPlayer;
		[Serialize("ejectForce"                     )] public float ejectForce;
		[Serialize("useDeathMargin"                 )] public int useDeathMargin;
		[Serialize("deathMargin"                    )] public Margin deathMargin;
		[Serialize("ignoreConstraint"               )] public int ignoreConstraint;
		[Serialize("timeOut"                        )] public float timeOut;
		[Serialize("lastOnscreenPlayerKillsEveryone")] public int lastOnscreenPlayerKillsEveryone;
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

