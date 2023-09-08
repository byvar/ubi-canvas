namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionCovertFromTarget_Template : BTAction_Template {
		public StringID factTarget;
		public float thresholdY = 1f;
		public float thresholdYDown = 0.6f;
		public float timeCarryingAllowed = 3f;
		public float radiusMaxTempo = 10f;
		public float timeMaxTempo = 1f;
		public Enum_forcedDirection forcedDirection;
		public StringID animIdle;
		public StringID animStandUp;
		public StringID animUTurnDn;
		public StringID animUTurnUp;
		public StringID animMoveShieldUp;
		public StringID animMoveShieldDn;
		public StringID animStartCarrying;
		public StringID animStopCarrying;
		public StringID animCarrying;
		public StringID animUturnUpEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
				thresholdY = s.Serialize<float>(thresholdY, name: "thresholdY");
				thresholdYDown = s.Serialize<float>(thresholdYDown, name: "thresholdYDown");
				timeCarryingAllowed = s.Serialize<float>(timeCarryingAllowed, name: "timeCarryingAllowed");
				radiusMaxTempo = s.Serialize<float>(radiusMaxTempo, name: "radiusMaxTempo");
				timeMaxTempo = s.Serialize<float>(timeMaxTempo, name: "timeMaxTempo");
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				animStandUp = s.SerializeObject<StringID>(animStandUp, name: "animStandUp");
				animUTurnDn = s.SerializeObject<StringID>(animUTurnDn, name: "animUTurnDn");
				animUTurnUp = s.SerializeObject<StringID>(animUTurnUp, name: "animUTurnUp");
				animMoveShieldUp = s.SerializeObject<StringID>(animMoveShieldUp, name: "animMoveShieldUp");
				animMoveShieldDn = s.SerializeObject<StringID>(animMoveShieldDn, name: "animMoveShieldDn");
				animStartCarrying = s.SerializeObject<StringID>(animStartCarrying, name: "animStartCarrying");
				animStopCarrying = s.SerializeObject<StringID>(animStopCarrying, name: "animStopCarrying");
				animCarrying = s.SerializeObject<StringID>(animCarrying, name: "animCarrying");
				animUturnUpEvent = s.SerializeObject<StringID>(animUturnUpEvent, name: "animUturnUpEvent");
			} else {
				factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
				thresholdY = s.Serialize<float>(thresholdY, name: "thresholdY");
				thresholdYDown = s.Serialize<float>(thresholdYDown, name: "thresholdYDown");
				timeCarryingAllowed = s.Serialize<float>(timeCarryingAllowed, name: "timeCarryingAllowed");
				radiusMaxTempo = s.Serialize<float>(radiusMaxTempo, name: "radiusMaxTempo");
				timeMaxTempo = s.Serialize<float>(timeMaxTempo, name: "timeMaxTempo");
				forcedDirection = s.Serialize<Enum_forcedDirection>(forcedDirection, name: "forcedDirection");
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				animStandUp = s.SerializeObject<StringID>(animStandUp, name: "animStandUp");
				animUTurnDn = s.SerializeObject<StringID>(animUTurnDn, name: "animUTurnDn");
				animUTurnUp = s.SerializeObject<StringID>(animUTurnUp, name: "animUTurnUp");
				animMoveShieldUp = s.SerializeObject<StringID>(animMoveShieldUp, name: "animMoveShieldUp");
				animMoveShieldDn = s.SerializeObject<StringID>(animMoveShieldDn, name: "animMoveShieldDn");
				animStartCarrying = s.SerializeObject<StringID>(animStartCarrying, name: "animStartCarrying");
				animStopCarrying = s.SerializeObject<StringID>(animStopCarrying, name: "animStopCarrying");
				animCarrying = s.SerializeObject<StringID>(animCarrying, name: "animCarrying");
				animUturnUpEvent = s.SerializeObject<StringID>(animUturnUpEvent, name: "animUturnUpEvent");
			}
		}
		public enum Enum_forcedDirection {
			[Serialize("No"        )] No = 0,
			[Serialize("ShieldUp"  )] ShieldUp = 1,
			[Serialize("ShieldDown")] ShieldDown = 2,
		}
		public override uint? ClassCRC => 0x5CBFA5D2;
	}
}

