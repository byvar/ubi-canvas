namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_CameraLimiterComponent_Template : ActorComponent_Template {
		public bool useEjectMargin = true;
		public Margin ejectMargin = new Margin() { left = -1f, right = -1f, top = -1f, bottom = -1f };
		public bool ejectMarginDeadPlayersOnly;
		public bool ejectMarginDetachesPlayer = true;
		public float ejectForce = 100f;
		public bool useDeathMargin = true;
		public Margin deathMargin = new Margin() { left = 1f, right = 1f, top = 1f, bottom = 1f };
		public float deathMarginWithBottomConstraint;
		public bool ignoreConstraint;
		public float timeOut = 2f;
		public bool lastOnscreenPlayerKillsEveryone = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useEjectMargin = s.Serialize<bool>(useEjectMargin, name: "useEjectMargin");
			ejectMargin = s.SerializeObject<Margin>(ejectMargin, name: "ejectMargin");
			ejectMarginDeadPlayersOnly = s.Serialize<bool>(ejectMarginDeadPlayersOnly, name: "ejectMarginDeadPlayersOnly");
			ejectMarginDetachesPlayer = s.Serialize<bool>(ejectMarginDetachesPlayer, name: "ejectMarginDetachesPlayer");
			ejectForce = s.Serialize<float>(ejectForce, name: "ejectForce");
			useDeathMargin = s.Serialize<bool>(useDeathMargin, name: "useDeathMargin");
			deathMargin = s.SerializeObject<Margin>(deathMargin, name: "deathMargin");
			deathMarginWithBottomConstraint = s.Serialize<float>(deathMarginWithBottomConstraint, name: "deathMarginWithBottomConstraint");
			ignoreConstraint = s.Serialize<bool>(ignoreConstraint, name: "ignoreConstraint");
			timeOut = s.Serialize<float>(timeOut, name: "timeOut");
			lastOnscreenPlayerKillsEveryone = s.Serialize<bool>(lastOnscreenPlayerKillsEveryone, name: "lastOnscreenPlayerKillsEveryone");
		}
		public override uint? ClassCRC => 0x33A50127;
	}
}

