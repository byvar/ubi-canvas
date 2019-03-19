using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TutoTriggerComponent : ActorComponent {
		[Serialize("displayToSpawn"             )] public Path displayToSpawn;
		[Serialize("displayAnim"                )] public StringID displayAnim;
		[Serialize("displayStartPos"            )] public Vector3 displayStartPos;
		[Serialize("displayStartPosAppleTV"     )] public Vector3 displayStartPosAppleTV;
		[Serialize("expectedCommand"            )] public Enum_expectedCommand expectedCommand;
		[Serialize("successDisplay"             )] public Path successDisplay;
		[Serialize("commandCheckOnly"           )] public bool commandCheckOnly;
		[Serialize("canBeReopened"              )] public bool canBeReopened;
		[Serialize("ActionsToResume"            )] public CList<RLC_TutoTriggerComponent.ActionToUnpause> ActionsToResume;
		[Serialize("needDirection"              )] public bool needDirection;
		[Serialize("directionSign"              )] public int directionSign;
		[Serialize("LocalisationTextID"         )] public SmartLocId LocalisationTextID;
		[Serialize("LocalisationTextIDPad"      )] public SmartLocId LocalisationTextIDPad;
		[Serialize("onResumeEvent"              )] public CArray<Generic<Event>> onResumeEvent;
		[Serialize("slowingTime"                )] public float slowingTime;
		[Serialize("activationTime"             )] public float activationTime;
		[Serialize("PauseInputDelay"            )] public float PauseInputDelay;
		[Serialize("disableAfterLevelCompletion")] public bool disableAfterLevelCompletion;
		[Serialize("disableAfterOnBoarding"     )] public bool disableAfterOnBoarding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(displayToSpawn));
			SerializeField(s, nameof(displayAnim));
			SerializeField(s, nameof(displayStartPos));
			SerializeField(s, nameof(displayStartPosAppleTV));
			SerializeField(s, nameof(expectedCommand));
			SerializeField(s, nameof(successDisplay));
			SerializeField(s, nameof(commandCheckOnly));
			SerializeField(s, nameof(canBeReopened));
			SerializeField(s, nameof(ActionsToResume));
			SerializeField(s, nameof(needDirection));
			SerializeField(s, nameof(directionSign));
			SerializeField(s, nameof(LocalisationTextID));
			SerializeField(s, nameof(LocalisationTextIDPad));
			SerializeField(s, nameof(onResumeEvent));
			SerializeField(s, nameof(slowingTime));
			SerializeField(s, nameof(activationTime));
			SerializeField(s, nameof(PauseInputDelay));
			SerializeField(s, nameof(disableAfterLevelCompletion));
			SerializeField(s, nameof(disableAfterOnBoarding));
		}
		[Games(GameFlags.RA)]
		public partial class ActionToUnpause : CSerializable {
			[Serialize("id"         )] public StringID id;
			[Serialize("axis"       )] public float axis;
			[Serialize("Comparation")] public ECompareType Comparation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(axis));
				SerializeField(s, nameof(Comparation));
			}
			public enum ECompareType {
				[Serialize("ECompareType_GreaterThan" )] GreaterThan = 1,
				[Serialize("ECompareType_GreaterEqual")] GreaterEqual = 2,
				[Serialize("ECompareType_Equal"       )] Equal = 3,
				[Serialize("ECompareType_LesserEqual" )] LesserEqual = 4,
				[Serialize("ECompareType_LesserThan"  )] LesserThan = 5,
			}
		}
		public enum Enum_expectedCommand {
			[Serialize("ZoneOnly"   )] ZoneOnly = 0,
			[Serialize("Jump"       )] Jump = 1,
			[Serialize("Helicopter" )] Helicopter = 2,
			[Serialize("SwipeRight" )] SwipeRight = 3,
			[Serialize("SwipeLeft"  )] SwipeLeft = 4,
			[Serialize("AttackRight")] AttackRight = 5,
			[Serialize("AttackLeft" )] AttackLeft = 6,
			[Serialize("CrushAttack")] CrushAttack = 7,
			[Serialize("WallJump"   )] WallJump = 8,
		}
		public override uint? ClassCRC => 0xE5CD1B08;
	}
}

