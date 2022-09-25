using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_DisplayTutoIconComponent : ActorComponent {
		public TutoType tutoType;
		public TutoType2 tutoType2;
		public float scale;
		public Vec3d offset;
		public bool offsetUseActorFlip;
		public Angle angleOffset;
		public float holdMinTime;
		public Vec3d pos;
		public bool displayTuto;
		public bool flip;
		public bool isPos2D;
		public bool activateByTrigger;
		public int activateByTriggerInt;
		public float cyclePauseDuration;
		public float cycleDisplayDuration;
		public bool testSceneDepthRef;
		public int AMActionCountMax;
		public bool tutoSucceeded;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					tutoType2 = s.Serialize<TutoType2>(tutoType2, name: "tutoType");
					scale = s.Serialize<float>(scale, name: "scale");
					offset = s.SerializeObject<Vec3d>(offset, name: "offset");
					offsetUseActorFlip = s.Serialize<bool>(offsetUseActorFlip, name: "offsetUseActorFlip");
					angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
					holdMinTime = s.Serialize<float>(holdMinTime, name: "holdMinTime");
					pos = s.SerializeObject<Vec3d>(pos, name: "pos");
					displayTuto = s.Serialize<bool>(displayTuto, name: "displayTuto", options: CSerializerObject.Options.BoolAsByte);
					flip = s.Serialize<bool>(flip, name: "flip", options: CSerializerObject.Options.BoolAsByte);
					isPos2D = s.Serialize<bool>(isPos2D, name: "isPos2D", options: CSerializerObject.Options.BoolAsByte);
					activateByTriggerInt = s.Serialize<int>(activateByTriggerInt, name: "activateByTrigger");
					cyclePauseDuration = s.Serialize<float>(cyclePauseDuration, name: "cyclePauseDuration");
					cycleDisplayDuration = s.Serialize<float>(cycleDisplayDuration, name: "cycleDisplayDuration");
					testSceneDepthRef = s.Serialize<bool>(testSceneDepthRef, name: "testSceneDepthRef", options: CSerializerObject.Options.BoolAsByte);
					if (!s.Settings.isCatchThemAll) {
						AMActionCountMax = s.Serialize<int>(AMActionCountMax, name: "AMActionCountMax");
					}
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					tutoSucceeded = s.Serialize<bool>(tutoSucceeded, name: "tutoSucceeded");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					tutoType = s.Serialize<TutoType>(tutoType, name: "tutoType");
					scale = s.Serialize<float>(scale, name: "scale");
					offset = s.SerializeObject<Vec3d>(offset, name: "offset");
					offsetUseActorFlip = s.Serialize<bool>(offsetUseActorFlip, name: "offsetUseActorFlip");
					angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
					holdMinTime = s.Serialize<float>(holdMinTime, name: "holdMinTime");
					pos = s.SerializeObject<Vec3d>(pos, name: "pos");
					displayTuto = s.Serialize<bool>(displayTuto, name: "displayTuto");
					flip = s.Serialize<bool>(flip, name: "flip");
					isPos2D = s.Serialize<bool>(isPos2D, name: "isPos2D");
					activateByTrigger = s.Serialize<bool>(activateByTrigger, name: "activateByTrigger");
					cyclePauseDuration = s.Serialize<float>(cyclePauseDuration, name: "cyclePauseDuration");
					cycleDisplayDuration = s.Serialize<float>(cycleDisplayDuration, name: "cycleDisplayDuration");
					testSceneDepthRef = s.Serialize<bool>(testSceneDepthRef, name: "testSceneDepthRef");
					AMActionCountMax = s.Serialize<int>(AMActionCountMax, name: "AMActionCountMax");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					tutoSucceeded = s.Serialize<bool>(tutoSucceeded, name: "tutoSucceeded");
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
		public enum TutoType2 {
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
			[Serialize("Value_73")] Value_73 = 73,
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
			[Serialize("Value_72")] Value_72 = 72,
			[Serialize("Value_74")] Value_74 = 74,
		}
		public override uint? ClassCRC => 0xCCD6E553;
	}
}

