using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_DisplayTutoIconComponent : ActorComponent {
		[Serialize(0, "tutoType")] public TutoType tutoType;
		[Serialize(1, "scale")] public float scale;
		[Serialize(2, "offset")] public Vector3 offset;
		[Serialize(3, "offsetUseActorFlip")] public bool offsetUseActorFlip;
		[Serialize(4, "angleOffset")] public Angle angleOffset;
		[Serialize(5, "holdMinTime")] public float holdMinTime;
		[Serialize(6, "pos")] public Vector3 pos;
		[Serialize(7, "displayTuto")] public bool displayTuto;
		[Serialize(8, "flip")] public bool flip;
		[Serialize(9, "isPos2D")] public bool isPos2D;
		[Serialize(10, "activateByTrigger")] public bool activateByTrigger;
		[Serialize(11, "cyclePauseDuration")] public float cyclePauseDuration;
		[Serialize(12, "cycleDisplayDuration")] public float cycleDisplayDuration;
		[Serialize(13, "testSceneDepthRef")] public bool testSceneDepthRef;
		[Serialize(14, "AMActionCountMax")] public int AMActionCountMax;


		public RO2_DisplayTutoIconComponent(Reader reader) : base(reader) {
		}

		public enum TutoType {
			None = 0,
			DRC_Circle = 2,
			DRC_Hold = 3,
			DRC_Rotate = 4,
			DRC_Swipe = 5,
			DRC_Tap = 6,
			DRC_Blow = 7,
			MAIN_Course = 9,
			DRC_Tickle = 12,
			DRC_DragShield = 19,
			MAIN_Jump = 13,
			MAIN_Hit = 14,
			MAIN_Up = 15,
			MAIN_Painting = 16,
			MAIN_SimplePainting = 17,
			MAIN_UpExit = 18,
			MAIN_ShooterFire = 27,
			MAIN_ShooterInhale = 28,
			MAIN_Unhook = 29,
			MAIN_PaintingAndDifficulty = 31,
			MAIN_ChargedPunch = 37,
			MAIN_ROShrink = 38,
			UNKNOWN = 73,
			MAIN_Dive = 39,
			MAIN_Sprint = 40,
			MAIN_Shoot = 41,
			MAIN_InhaleOnly = 42,
			MAIN_ShootInhale = 43,
			MAIN_InhaleAndFire = 44,
			MAIN_Punch = 20,
			MAIN_CrushAttack = 21,
			MAIN_Hairlico = 22,
			MAIN_Swim = 23,
			MAIN_WallJump = 24,
			MAIN_Shrink = 25,
			MAIN_WallRun = 26,
			MAIN_FirstTapTuto = 45,
			MAIN_BubbleDreamerTuto = 46,
			MAIN_WallRunLeft = 47,
			MAIN_PauseHelp = 48,
			MAIN_FirstTapTutoAM = 49,
			AM_CutTheStilt = 50,
			AM_GrabWheel = 51,
			AM_RotateWheel = 52,
			AM_Tickle = 53,
			AM_HitCreature = 54,
			AM_HitGhost = 55,
			AM_CutTheRope = 56,
			AM_MoveLever = 57,
			AM_MovePlatform = 58,
			AM_LiftTheObstacle = 59,
			AM_MoveTheBouncingPlant = 60,
			AM_HitPlant = 61,
			AM_Eat = 62,
			AM_Guacamole = 63,
			AM_ShieldFwd = 64,
			AM_ShieldBwd = 65,
			AM_EvilSaw = 66,
			AM_PressButton = 67,
			AM_MoveObject = 68,
			AM_MoveTheObstacle = 69,
			UNKNOWN2 = 72,
			UNKNOWN3 = 74,
		}
	}
}
