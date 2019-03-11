using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionCovertFromTarget_Template : BTAction_Template {
		[Serialize("factTarget"         )] public StringID factTarget;
		[Serialize("thresholdY"         )] public float thresholdY;
		[Serialize("thresholdYDown"     )] public float thresholdYDown;
		[Serialize("timeCarryingAllowed")] public float timeCarryingAllowed;
		[Serialize("radiusMaxTempo"     )] public float radiusMaxTempo;
		[Serialize("timeMaxTempo"       )] public float timeMaxTempo;
		[Serialize("forcedDirection"    )] public Enum_forcedDirection forcedDirection;
		[Serialize("animIdle"           )] public StringID animIdle;
		[Serialize("animStandUp"        )] public StringID animStandUp;
		[Serialize("animUTurnDn"        )] public StringID animUTurnDn;
		[Serialize("animUTurnUp"        )] public StringID animUTurnUp;
		[Serialize("animMoveShieldUp"   )] public StringID animMoveShieldUp;
		[Serialize("animMoveShieldDn"   )] public StringID animMoveShieldDn;
		[Serialize("animStartCarrying"  )] public StringID animStartCarrying;
		[Serialize("animStopCarrying"   )] public StringID animStopCarrying;
		[Serialize("animCarrying"       )] public StringID animCarrying;
		[Serialize("animUturnUpEvent"   )] public StringID animUturnUpEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(factTarget));
				SerializeField(s, nameof(thresholdY));
				SerializeField(s, nameof(thresholdYDown));
				SerializeField(s, nameof(timeCarryingAllowed));
				SerializeField(s, nameof(radiusMaxTempo));
				SerializeField(s, nameof(timeMaxTempo));
				SerializeField(s, nameof(animIdle));
				SerializeField(s, nameof(animStandUp));
				SerializeField(s, nameof(animUTurnDn));
				SerializeField(s, nameof(animUTurnUp));
				SerializeField(s, nameof(animMoveShieldUp));
				SerializeField(s, nameof(animMoveShieldDn));
				SerializeField(s, nameof(animStartCarrying));
				SerializeField(s, nameof(animStopCarrying));
				SerializeField(s, nameof(animCarrying));
				SerializeField(s, nameof(animUturnUpEvent));
			} else {
				SerializeField(s, nameof(factTarget));
				SerializeField(s, nameof(thresholdY));
				SerializeField(s, nameof(thresholdYDown));
				SerializeField(s, nameof(timeCarryingAllowed));
				SerializeField(s, nameof(radiusMaxTempo));
				SerializeField(s, nameof(timeMaxTempo));
				SerializeField(s, nameof(forcedDirection));
				SerializeField(s, nameof(animIdle));
				SerializeField(s, nameof(animStandUp));
				SerializeField(s, nameof(animUTurnDn));
				SerializeField(s, nameof(animUTurnUp));
				SerializeField(s, nameof(animMoveShieldUp));
				SerializeField(s, nameof(animMoveShieldDn));
				SerializeField(s, nameof(animStartCarrying));
				SerializeField(s, nameof(animStopCarrying));
				SerializeField(s, nameof(animCarrying));
				SerializeField(s, nameof(animUturnUpEvent));
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

