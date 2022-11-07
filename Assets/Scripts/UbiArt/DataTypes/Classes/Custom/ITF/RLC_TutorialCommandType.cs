namespace UbiArt.ITF {
	public enum RLC_TutorialCommandType {
		[Serialize("RLC_TutorialCommandType_None"       )] None = 0,
		[Serialize("RLC_TutorialCommandType_Jump"       )] Jump = 1,
		[Serialize("RLC_TutorialCommandType_Helicopter" )] Helicopter = 2,
		[Serialize("RLC_TutorialCommandType_SwipeRight" )] SwipeRight = 3,
		[Serialize("RLC_TutorialCommandType_SwipeLeft"  )] SwipeLeft = 4,
		[Serialize("RLC_TutorialCommandType_AttackRight")] AttackRight = 5,
		[Serialize("RLC_TutorialCommandType_AttackLeft" )] AttackLeft = 6,
		[Serialize("RLC_TutorialCommandType_CrushAttack")] CrushAttack = 7,
		[Serialize("RLC_TutorialCommandType_WallJump"   )] WallJump = 8,
		[Serialize("RLC_TutorialCommandType_Count"      )] Count = 9,
	}
}

