using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_PlatformerCameraComponent_Template : InGameCameraComponent_Template {
		public bool useEjectMargin;
		public float ejectMargin;
		public bool ejectMarginDeadPlayersOnly;
		public bool ejectMarginDetachesPlayer;
		public float ejectForce;
		public bool useDeathMargin;
		public float deathMargin;
		public float deathMarginWithBottomConstraint;
		public float timeOut;
		public bool lastOnscreenPlayerKillsEveryone;
		public bool pursuitUseDeathMargin;
		public float pursuitDeathMargin;
		public float pursuitTimeOut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useEjectMargin = s.Serialize<bool>(useEjectMargin, name: "useEjectMargin");
			ejectMargin = s.Serialize<float>(ejectMargin, name: "ejectMargin");
			ejectMarginDeadPlayersOnly = s.Serialize<bool>(ejectMarginDeadPlayersOnly, name: "ejectMarginDeadPlayersOnly");
			ejectMarginDetachesPlayer = s.Serialize<bool>(ejectMarginDetachesPlayer, name: "ejectMarginDetachesPlayer");
			ejectForce = s.Serialize<float>(ejectForce, name: "ejectForce");
			useDeathMargin = s.Serialize<bool>(useDeathMargin, name: "useDeathMargin");
			deathMargin = s.Serialize<float>(deathMargin, name: "deathMargin");
			deathMarginWithBottomConstraint = s.Serialize<float>(deathMarginWithBottomConstraint, name: "deathMarginWithBottomConstraint");
			timeOut = s.Serialize<float>(timeOut, name: "timeOut");
			lastOnscreenPlayerKillsEveryone = s.Serialize<bool>(lastOnscreenPlayerKillsEveryone, name: "lastOnscreenPlayerKillsEveryone");
			pursuitUseDeathMargin = s.Serialize<bool>(pursuitUseDeathMargin, name: "pursuitUseDeathMargin");
			pursuitDeathMargin = s.Serialize<float>(pursuitDeathMargin, name: "pursuitDeathMargin");
			pursuitTimeOut = s.Serialize<float>(pursuitTimeOut, name: "pursuitTimeOut");
		}
		public override uint? ClassCRC => 0x57790C7C;
	}
}

