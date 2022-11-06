using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_CameraLimiterComponent_Template : CSerializable {
		public int useEjectMargin;
		public Margin ejectMargin;
		public int ejectMarginDetachesPlayer;
		public float ejectForce;
		public int useDeathMargin;
		public Margin deathMargin;
		public int ignoreConstraint;
		public float timeOut;
		public int lastOnscreenPlayerKillsEveryone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useEjectMargin = s.Serialize<int>(useEjectMargin, name: "useEjectMargin");
			ejectMargin = s.SerializeObject<Margin>(ejectMargin, name: "ejectMargin");
			ejectMarginDetachesPlayer = s.Serialize<int>(ejectMarginDetachesPlayer, name: "ejectMarginDetachesPlayer");
			ejectForce = s.Serialize<float>(ejectForce, name: "ejectForce");
			useDeathMargin = s.Serialize<int>(useDeathMargin, name: "useDeathMargin");
			deathMargin = s.SerializeObject<Margin>(deathMargin, name: "deathMargin");
			ignoreConstraint = s.Serialize<int>(ignoreConstraint, name: "ignoreConstraint");
			timeOut = s.Serialize<float>(timeOut, name: "timeOut");
			lastOnscreenPlayerKillsEveryone = s.Serialize<int>(lastOnscreenPlayerKillsEveryone, name: "lastOnscreenPlayerKillsEveryone");
		}
		public override uint? ClassCRC => 0xF7DA5110;
	}
}

