using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_TutoTriggerComponent : ActorComponent {
		public Path displayToSpawn;
		public StringID displayAnim;
		public Vec3d displayStartPos;
		public Vec3d displayStartPosAppleTV;
		public Enum_expectedCommand expectedCommand;
		public Path successDisplay;
		public bool commandCheckOnly;
		public bool canBeReopened;
		public CListO<RLC_TutoTriggerComponent.ActionToUnpause> ActionsToResume;
		public bool needDirection;
		public int directionSign;
		public SmartLocId LocalisationTextID;
		public SmartLocId LocalisationTextIDPad;
		public CArrayO<Generic<Event>> onResumeEvent;
		public float slowingTime;
		public float activationTime;
		public float PauseInputDelay;
		public bool disableAfterLevelCompletion;
		public bool disableAfterOnBoarding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			displayToSpawn = s.SerializeObject<Path>(displayToSpawn, name: "displayToSpawn");
			displayAnim = s.SerializeObject<StringID>(displayAnim, name: "displayAnim");
			displayStartPos = s.SerializeObject<Vec3d>(displayStartPos, name: "displayStartPos");
			displayStartPosAppleTV = s.SerializeObject<Vec3d>(displayStartPosAppleTV, name: "displayStartPosAppleTV");
			expectedCommand = s.Serialize<Enum_expectedCommand>(expectedCommand, name: "expectedCommand");
			successDisplay = s.SerializeObject<Path>(successDisplay, name: "successDisplay");
			commandCheckOnly = s.Serialize<bool>(commandCheckOnly, name: "commandCheckOnly");
			canBeReopened = s.Serialize<bool>(canBeReopened, name: "canBeReopened");
			ActionsToResume = s.SerializeObject<CListO<RLC_TutoTriggerComponent.ActionToUnpause>>(ActionsToResume, name: "ActionsToResume");
			needDirection = s.Serialize<bool>(needDirection, name: "needDirection");
			directionSign = s.Serialize<int>(directionSign, name: "directionSign");
			LocalisationTextID = s.SerializeObject<SmartLocId>(LocalisationTextID, name: "LocalisationTextID");
			LocalisationTextIDPad = s.SerializeObject<SmartLocId>(LocalisationTextIDPad, name: "LocalisationTextIDPad");
			onResumeEvent = s.SerializeObject<CArrayO<Generic<Event>>>(onResumeEvent, name: "onResumeEvent");
			slowingTime = s.Serialize<float>(slowingTime, name: "slowingTime");
			activationTime = s.Serialize<float>(activationTime, name: "activationTime");
			PauseInputDelay = s.Serialize<float>(PauseInputDelay, name: "PauseInputDelay");
			disableAfterLevelCompletion = s.Serialize<bool>(disableAfterLevelCompletion, name: "disableAfterLevelCompletion");
			disableAfterOnBoarding = s.Serialize<bool>(disableAfterOnBoarding, name: "disableAfterOnBoarding");
		}
		[Games(GameFlags.RA)]
		public partial class ActionToUnpause : CSerializable {
			public StringID id;
			public float axis;
			public ECompareType Comparation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				id = s.SerializeObject<StringID>(id, name: "id");
				axis = s.Serialize<float>(axis, name: "axis");
				Comparation = s.Serialize<ECompareType>(Comparation, name: "Comparation");
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

