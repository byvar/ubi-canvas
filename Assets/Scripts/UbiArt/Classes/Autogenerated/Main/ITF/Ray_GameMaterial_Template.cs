using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_GameMaterial_Template : GameMaterial_Template {
		[Serialize("Bounce"                      )] public int Bounce;
		[Serialize("BounceType"                  )] public Enum_RJR_0 BounceType;
		[Serialize("Wave"                        )] public int Wave;
		[Serialize("climbable"                   )] public int climbable;
		[Serialize("hangable"                    )] public int hangable;
		[Serialize("IgnoreCorners"               )] public int IgnoreCorners;
		[Serialize("Character"                   )] public int Character;
		[Serialize("IgnoreLowRoof"               )] public int IgnoreLowRoof;
		[Serialize("CanFruitStick"               )] public int CanFruitStick;
		[Serialize("climbVertical"               )] public int climbVertical;
		[Serialize("climbSlide"                  )] public int climbSlide;
		[Serialize("climbForceSideJump"          )] public int climbForceSideJump;
		[Serialize("noSquashDamage"              )] public int noSquashDamage;
		[Serialize("bounceOnCrushAttack"         )] public int bounceOnCrushAttack;
		[Serialize("Dangerous"                   )] public uint Dangerous;
		[Serialize("movePlatformSpeedXMultiplier")] public float movePlatformSpeedXMultiplier;
		[Serialize("movePlatformSpeedYMultiplier")] public float movePlatformSpeedYMultiplier;
		[Serialize("shooterBounce"               )] public int shooterBounce;
		[Serialize("djembe"                      )] public float djembe;
		[Serialize("int__0"                      )] public int int__0;
		[Serialize("Enum_RFR_0__1"               )] public Enum_RFR_0 Enum_RFR_0__1;
		[Serialize("int__2"                      )] public int int__2;
		[Serialize("int__3"                      )] public int int__3;
		[Serialize("int__4"                      )] public int int__4;
		[Serialize("int__5"                      )] public int int__5;
		[Serialize("int__6"                      )] public int int__6;
		[Serialize("int__7"                      )] public int int__7;
		[Serialize("int__8"                      )] public int int__8;
		[Serialize("int__9"                      )] public int int__9;
		[Serialize("int__10"                     )] public int int__10;
		[Serialize("int__11"                     )] public int int__11;
		[Serialize("int__12"                     )] public int int__12;
		[Serialize("int__13"                     )] public int int__13;
		[Serialize("uint__14"                    )] public uint uint__14;
		[Serialize("float__15"                   )] public float float__15;
		[Serialize("float__16"                   )] public float float__16;
		[Serialize("int__17"                     )] public int int__17;
		[Serialize("float__18"                   )] public float float__18;
		[Serialize("float__19"                   )] public float float__19;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(Enum_RFR_0__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(int__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(int__11));
				SerializeField(s, nameof(int__12));
				SerializeField(s, nameof(int__13));
				SerializeField(s, nameof(uint__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(int__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
			} else {
				SerializeField(s, nameof(Bounce));
				SerializeField(s, nameof(BounceType));
				SerializeField(s, nameof(Wave));
				SerializeField(s, nameof(climbable));
				SerializeField(s, nameof(hangable));
				SerializeField(s, nameof(IgnoreCorners));
				SerializeField(s, nameof(Character));
				SerializeField(s, nameof(IgnoreLowRoof));
				SerializeField(s, nameof(CanFruitStick));
				SerializeField(s, nameof(climbVertical));
				SerializeField(s, nameof(climbSlide));
				SerializeField(s, nameof(climbForceSideJump));
				SerializeField(s, nameof(noSquashDamage));
				SerializeField(s, nameof(bounceOnCrushAttack));
				SerializeField(s, nameof(Dangerous));
				SerializeField(s, nameof(movePlatformSpeedXMultiplier));
				SerializeField(s, nameof(movePlatformSpeedYMultiplier));
				SerializeField(s, nameof(shooterBounce));
				SerializeField(s, nameof(djembe));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public override uint? ClassCRC => 0xA58BAE74;
	}
}

