using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_PlatformerCameraComponent_Template : InGameCameraComponent_Template {
		public int useEjectMargin;
		public float ejectMargin;
		public int ejectMarginDetachesPlayer;
		public float ejectForce;
		public int useDeathMargin;
		public float deathMargin;
		public float timeOut;
		public int lastOnscreenPlayerKillsEveryone;
		public int pursuitUseDeathMargin;
		public float pursuitDeathMargin;
		public float pursuitTimeOut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useEjectMargin = s.Serialize<int>(useEjectMargin, name: "useEjectMargin");
			ejectMargin = s.Serialize<float>(ejectMargin, name: "ejectMargin");
			ejectMarginDetachesPlayer = s.Serialize<int>(ejectMarginDetachesPlayer, name: "ejectMarginDetachesPlayer");
			ejectForce = s.Serialize<float>(ejectForce, name: "ejectForce");
			useDeathMargin = s.Serialize<int>(useDeathMargin, name: "useDeathMargin");
			deathMargin = s.Serialize<float>(deathMargin, name: "deathMargin");
			timeOut = s.Serialize<float>(timeOut, name: "timeOut");
			lastOnscreenPlayerKillsEveryone = s.Serialize<int>(lastOnscreenPlayerKillsEveryone, name: "lastOnscreenPlayerKillsEveryone");
			pursuitUseDeathMargin = s.Serialize<int>(pursuitUseDeathMargin, name: "pursuitUseDeathMargin");
			pursuitDeathMargin = s.Serialize<float>(pursuitDeathMargin, name: "pursuitDeathMargin");
			pursuitTimeOut = s.Serialize<float>(pursuitTimeOut, name: "pursuitTimeOut");
		}
		public override uint? ClassCRC => 0x2A9ACB4C;
	}
}

