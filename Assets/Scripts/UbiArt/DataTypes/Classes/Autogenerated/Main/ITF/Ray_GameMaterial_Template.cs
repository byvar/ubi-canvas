using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_GameMaterial_Template : GameMaterial_Template {
		public int Bounce;
		public Enum_RJR_0 BounceType;
		public int Wave;
		public int climbable;
		public int hangable;
		public int IgnoreCorners;
		public int Character;
		public int IgnoreLowRoof;
		public int CanFruitStick;
		public int climbVertical;
		public int climbSlide;
		public int climbForceSideJump;
		public int noSquashDamage;
		public int bounceOnCrushAttack;
		public uint Dangerous;
		public float movePlatformSpeedXMultiplier;
		public float movePlatformSpeedYMultiplier;
		public int shooterBounce;
		public float djembe;
		public int int__0;
		public Enum_RFR_0 Enum_RFR_0__1;
		public int int__2;
		public int int__3;
		public int int__4;
		public int int__5;
		public int int__6;
		public int int__7;
		public int int__8;
		public int int__9;
		public int int__10;
		public int int__11;
		public int int__12;
		public int int__13;
		public uint uint__14;
		public float float__15;
		public float float__16;
		public int int__17;
		public float float__18;
		public float float__19;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				int__0 = s.Serialize<int>(int__0, name: "int__0");
				Enum_RFR_0__1 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__1, name: "Enum_RFR_0__1");
				int__2 = s.Serialize<int>(int__2, name: "int__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
				int__4 = s.Serialize<int>(int__4, name: "int__4");
				int__5 = s.Serialize<int>(int__5, name: "int__5");
				int__6 = s.Serialize<int>(int__6, name: "int__6");
				int__7 = s.Serialize<int>(int__7, name: "int__7");
				int__8 = s.Serialize<int>(int__8, name: "int__8");
				int__9 = s.Serialize<int>(int__9, name: "int__9");
				int__10 = s.Serialize<int>(int__10, name: "int__10");
				int__11 = s.Serialize<int>(int__11, name: "int__11");
				int__12 = s.Serialize<int>(int__12, name: "int__12");
				int__13 = s.Serialize<int>(int__13, name: "int__13");
				uint__14 = s.Serialize<uint>(uint__14, name: "uint__14");
				float__15 = s.Serialize<float>(float__15, name: "float__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				int__17 = s.Serialize<int>(int__17, name: "int__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				float__19 = s.Serialize<float>(float__19, name: "float__19");
			} else {
				Bounce = s.Serialize<int>(Bounce, name: "Bounce");
				BounceType = s.Serialize<Enum_RJR_0>(BounceType, name: "BounceType");
				Wave = s.Serialize<int>(Wave, name: "Wave");
				climbable = s.Serialize<int>(climbable, name: "climbable");
				hangable = s.Serialize<int>(hangable, name: "hangable");
				IgnoreCorners = s.Serialize<int>(IgnoreCorners, name: "IgnoreCorners");
				Character = s.Serialize<int>(Character, name: "Character");
				IgnoreLowRoof = s.Serialize<int>(IgnoreLowRoof, name: "IgnoreLowRoof");
				CanFruitStick = s.Serialize<int>(CanFruitStick, name: "CanFruitStick");
				climbVertical = s.Serialize<int>(climbVertical, name: "climbVertical");
				climbSlide = s.Serialize<int>(climbSlide, name: "climbSlide");
				climbForceSideJump = s.Serialize<int>(climbForceSideJump, name: "climbForceSideJump");
				noSquashDamage = s.Serialize<int>(noSquashDamage, name: "noSquashDamage");
				bounceOnCrushAttack = s.Serialize<int>(bounceOnCrushAttack, name: "bounceOnCrushAttack");
				Dangerous = s.Serialize<uint>(Dangerous, name: "Dangerous");
				movePlatformSpeedXMultiplier = s.Serialize<float>(movePlatformSpeedXMultiplier, name: "movePlatformSpeedXMultiplier");
				movePlatformSpeedYMultiplier = s.Serialize<float>(movePlatformSpeedYMultiplier, name: "movePlatformSpeedYMultiplier");
				shooterBounce = s.Serialize<int>(shooterBounce, name: "shooterBounce");
				djembe = s.Serialize<float>(djembe, name: "djembe");
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

