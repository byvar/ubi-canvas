using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DisplayTutoIconComponent : ActorComponent {
		[Serialize("tutoType"            )] public TutoType tutoType;
		[Serialize("scale"               )] public float scale;
		[Serialize("offset"              )] public Vector3 offset;
		[Serialize("offsetUseActorFlip"  )] public bool offsetUseActorFlip;
		[Serialize("angleOffset"         )] public Angle angleOffset;
		[Serialize("holdMinTime"         )] public float holdMinTime;
		[Serialize("pos"                 )] public Vector3 pos;
		[Serialize("displayTuto"         )] public bool displayTuto;
		[Serialize("flip"                )] public bool flip;
		[Serialize("isPos2D"             )] public bool isPos2D;
		[Serialize("activateByTrigger"   )] public bool activateByTrigger;
		[Serialize("cyclePauseDuration"  )] public float cyclePauseDuration;
		[Serialize("cycleDisplayDuration")] public float cycleDisplayDuration;
		[Serialize("testSceneDepthRef"   )] public bool testSceneDepthRef;
		[Serialize("AMActionCountMax"    )] public int AMActionCountMax;
		[Serialize("tutoSucceeded"       )] public bool tutoSucceeded;
		[Serialize("tutoType"            )] public Enum_tutoType tutoType;
		[Serialize("AMActionCountMax"    )] public bool AMActionCountMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(tutoType));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(offsetUseActorFlip));
					SerializeField(s, nameof(angleOffset));
					SerializeField(s, nameof(holdMinTime));
					SerializeField(s, nameof(pos));
					SerializeField(s, nameof(displayTuto));
					SerializeField(s, nameof(flip));
					SerializeField(s, nameof(isPos2D));
					SerializeField(s, nameof(activateByTrigger));
					SerializeField(s, nameof(cyclePauseDuration));
					SerializeField(s, nameof(cycleDisplayDuration));
					SerializeField(s, nameof(testSceneDepthRef));
					SerializeField(s, nameof(AMActionCountMax));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(tutoSucceeded));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(tutoType));
					SerializeField(s, nameof(scale));
					SerializeField(s, nameof(offset));
					SerializeField(s, nameof(offsetUseActorFlip));
					SerializeField(s, nameof(angleOffset));
					SerializeField(s, nameof(holdMinTime));
					SerializeField(s, nameof(pos));
					SerializeField(s, nameof(displayTuto));
					SerializeField(s, nameof(flip));
					SerializeField(s, nameof(isPos2D));
					SerializeField(s, nameof(activateByTrigger));
					SerializeField(s, nameof(cyclePauseDuration));
					SerializeField(s, nameof(cycleDisplayDuration));
					SerializeField(s, nameof(testSceneDepthRef));
					SerializeField(s, nameof(AMActionCountMax));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(tutoSucceeded));
				}
			}
		}
		public enum TutoType {
			[Serialize("TutoType_None"                      )] None = 0,
			[Serialize("TutoType_DRC_Circle"                )] DRC_Circle = 2,
			[Serialize("TutoType_DRC_Hold"                  )] DRC_Hold = 3,
			[Serialize("TutoType_DRC_Rotate"                )] DRC_Rotate = 4,
			[Serialize("TutoType_DRC_Swipe"                 )] DRC_Swipe = 5,
			[Serialize("TutoType_DRC_Tap"                   )] DRC_Tap = 6,
			[Serialize("TutoType_DRC_Blow"                  )] DRC_Blow = 7,
			[Serialize("TutoType_MAIN_Course"               )] MAIN_Course = 9,
			[Serialize("TutoType_DRC_Tickle"                )] DRC_Tickle = 12,
			[Serialize("TutoType_DRC_DragShield"            )] DRC_DragShield = 19,
			[Serialize("TutoType_MAIN_Jump"                 )] MAIN_Jump = 13,
			[Serialize("TutoType_MAIN_Hit"                  )] MAIN_Hit = 14,
			[Serialize("TutoType_MAIN_Up"                   )] MAIN_Up = 15,
			[Serialize("TutoType_MAIN_Painting"             )] MAIN_Painting = 16,
			[Serialize("TutoType_MAIN_SimplePainting"       )] MAIN_SimplePainting = 17,
			[Serialize("TutoType_MAIN_UpExit"               )] MAIN_UpExit = 18,
			[Serialize("TutoType_MAIN_ShooterFire"          )] MAIN_ShooterFire = 27,
			[Serialize("TutoType_MAIN_ShooterInhale"        )] MAIN_ShooterInhale = 28,
			[Serialize("TutoType_MAIN_Unhook"               )] MAIN_Unhook = 29,
			[Serialize("TutoType_MAIN_PaintingAndDifficulty")] MAIN_PaintingAndDifficulty = 31,
			[Serialize("TutoType_MAIN_ChargedPunch"         )] MAIN_ChargedPunch = 37,
			[Serialize("TutoType_MAIN_ROShrink"             )] MAIN_ROShrink = 38,
			[Serialize("TutoType_MAIN_Dive"                 )] MAIN_Dive = 39,
			[Serialize("TutoType_MAIN_Sprint"               )] MAIN_Sprint = 40,
			[Serialize("TutoType_MAIN_Shoot"                )] MAIN_Shoot = 41,
			[Serialize("TutoType_MAIN_InhaleOnly"           )] MAIN_InhaleOnly = 42,
			[Serialize("TutoType_MAIN_ShootInhale"          )] MAIN_ShootInhale = 43,
			[Serialize("TutoType_MAIN_InhaleAndFire"        )] MAIN_InhaleAndFire = 44,
			[Serialize("TutoType_MAIN_Punch"                )] MAIN_Punch = 20,
			[Serialize("TutoType_MAIN_CrushAttack"          )] MAIN_CrushAttack = 21,
			[Serialize("TutoType_MAIN_Hairlico"             )] MAIN_Hairlico = 22,
			[Serialize("TutoType_MAIN_Swim"                 )] MAIN_Swim = 23,
			[Serialize("TutoType_MAIN_WallJump"             )] MAIN_WallJump = 24,
			[Serialize("TutoType_MAIN_Shrink"               )] MAIN_Shrink = 25,
			[Serialize("TutoType_MAIN_WallRun"              )] MAIN_WallRun = 26,
			[Serialize("TutoType_MAIN_FirstTapTuto"         )] MAIN_FirstTapTuto = 45,
			[Serialize("TutoType_MAIN_BubbleDreamerTuto"    )] MAIN_BubbleDreamerTuto = 46,
			[Serialize("TutoType_MAIN_WallRunLeft"          )] MAIN_WallRunLeft = 47,
			[Serialize("TutoType_MAIN_PauseHelp"            )] MAIN_PauseHelp = 48,
			[Serialize("TutoType_MAIN_FirstTapTutoAM"       )] MAIN_FirstTapTutoAM = 49,
			[Serialize("TutoType_AM_CutTheStilt"            )] AM_CutTheStilt = 50,
			[Serialize("TutoType_AM_GrabWheel"              )] AM_GrabWheel = 51,
			[Serialize("TutoType_AM_RotateWheel"            )] AM_RotateWheel = 52,
			[Serialize("TutoType_AM_Tickle"                 )] AM_Tickle = 53,
			[Serialize("TutoType_AM_HitCreature"            )] AM_HitCreature = 54,
			[Serialize("TutoType_AM_HitGhost"               )] AM_HitGhost = 55,
			[Serialize("TutoType_AM_CutTheRope"             )] AM_CutTheRope = 56,
			[Serialize("TutoType_AM_MoveLever"              )] AM_MoveLever = 57,
			[Serialize("TutoType_AM_MovePlatform"           )] AM_MovePlatform = 58,
			[Serialize("TutoType_AM_LiftTheObstacle"        )] AM_LiftTheObstacle = 59,
			[Serialize("TutoType_AM_MoveTheBouncingPlant"   )] AM_MoveTheBouncingPlant = 60,
			[Serialize("TutoType_AM_HitPlant"               )] AM_HitPlant = 61,
			[Serialize("TutoType_AM_Eat"                    )] AM_Eat = 62,
			[Serialize("TutoType_AM_Guacamole"              )] AM_Guacamole = 63,
			[Serialize("TutoType_AM_ShieldFwd"              )] AM_ShieldFwd = 64,
			[Serialize("TutoType_AM_ShieldBwd"              )] AM_ShieldBwd = 65,
			[Serialize("TutoType_AM_EvilSaw"                )] AM_EvilSaw = 66,
			[Serialize("TutoType_AM_PressButton"            )] AM_PressButton = 67,
			[Serialize("TutoType_AM_MoveObject"             )] AM_MoveObject = 68,
			[Serialize("TutoType_AM_MoveTheObstacle"        )] AM_MoveTheObstacle = 69,
		}
		public enum Enum_tutoType {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_19")] Value_19 = 19,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
			[Serialize("Value_27")] Value_27 = 27,
			[Serialize("Value_28")] Value_28 = 28,
			[Serialize("Value_29")] Value_29 = 29,
			[Serialize("Value_31")] Value_31 = 31,
			[Serialize("Value_37")] Value_37 = 37,
			[Serialize("Value_38")] Value_38 = 38,
			[Serialize("Value_73")] Value_73 = 73,
			[Serialize("Value_39")] Value_39 = 39,
			[Serialize("Value_40")] Value_40 = 40,
			[Serialize("Value_41")] Value_41 = 41,
			[Serialize("Value_42")] Value_42 = 42,
			[Serialize("Value_43")] Value_43 = 43,
			[Serialize("Value_44")] Value_44 = 44,
			[Serialize("Value_20")] Value_20 = 20,
			[Serialize("Value_21")] Value_21 = 21,
			[Serialize("Value_22")] Value_22 = 22,
			[Serialize("Value_23")] Value_23 = 23,
			[Serialize("Value_24")] Value_24 = 24,
			[Serialize("Value_25")] Value_25 = 25,
			[Serialize("Value_26")] Value_26 = 26,
			[Serialize("Value_45")] Value_45 = 45,
			[Serialize("Value_46")] Value_46 = 46,
			[Serialize("Value_47")] Value_47 = 47,
			[Serialize("Value_48")] Value_48 = 48,
			[Serialize("Value_49")] Value_49 = 49,
			[Serialize("Value_50")] Value_50 = 50,
			[Serialize("Value_51")] Value_51 = 51,
			[Serialize("Value_52")] Value_52 = 52,
			[Serialize("Value_53")] Value_53 = 53,
			[Serialize("Value_54")] Value_54 = 54,
			[Serialize("Value_55")] Value_55 = 55,
			[Serialize("Value_56")] Value_56 = 56,
			[Serialize("Value_57")] Value_57 = 57,
			[Serialize("Value_58")] Value_58 = 58,
			[Serialize("Value_59")] Value_59 = 59,
			[Serialize("Value_60")] Value_60 = 60,
			[Serialize("Value_61")] Value_61 = 61,
			[Serialize("Value_62")] Value_62 = 62,
			[Serialize("Value_63")] Value_63 = 63,
			[Serialize("Value_64")] Value_64 = 64,
			[Serialize("Value_65")] Value_65 = 65,
			[Serialize("Value_66")] Value_66 = 66,
			[Serialize("Value_67")] Value_67 = 67,
			[Serialize("Value_68")] Value_68 = 68,
			[Serialize("Value_69")] Value_69 = 69,
			[Serialize("Value_72")] Value_72 = 72,
			[Serialize("Value_74")] Value_74 = 74,
		}
		public override uint? ClassCRC => 0xCCD6E553;
	}
}

