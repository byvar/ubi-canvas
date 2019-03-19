using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_GameMaterial_Template : GameMaterial_Template {
		[Serialize("Bounce"                      )] public bool Bounce;
		[Serialize("BounceType"                  )] public BOUNCETYPE BounceType;
		[Serialize("Wave"                        )] public bool Wave;
		[Serialize("climbable"                   )] public bool climbable;
		[Serialize("hangable"                    )] public bool hangable;
		[Serialize("IgnoreCorners"               )] public bool IgnoreCorners;
		[Serialize("Character"                   )] public bool Character;
		[Serialize("IgnoreLowRoof"               )] public bool IgnoreLowRoof;
		[Serialize("CanFruitStick"               )] public bool CanFruitStick;
		[Serialize("climbVertical"               )] public bool climbVertical;
		[Serialize("climbSlide"                  )] public bool climbSlide;
		[Serialize("climbForceSideJump"          )] public bool climbForceSideJump;
		[Serialize("castShadow"                  )] public bool castShadow;
		[Serialize("noSquashDamage"              )] public bool noSquashDamage;
		[Serialize("bounceOnCrushAttack"         )] public bool bounceOnCrushAttack;
		[Serialize("Dangerous"                   )] public uint Dangerous;
		[Serialize("movePlatformSpeedXMultiplier")] public float movePlatformSpeedXMultiplier;
		[Serialize("movePlatformSpeedYMultiplier")] public float movePlatformSpeedYMultiplier;
		[Serialize("shooterBounce"               )] public bool shooterBounce;
		[Serialize("djembe"                      )] public float djembe;
		[Serialize("wallSlidable"                )] public bool wallSlidable;
		[Serialize("wallJumpable"                )] public bool wallJumpable;
		[Serialize("noSoftColl"                  )] public bool noSoftColl;
		[Serialize("noFriendlyFire"              )] public bool noFriendlyFire;
		[Serialize("destroyBoulders"             )] public bool destroyBoulders;
		[Serialize("crossableByBullet"           )] public bool crossableByBullet;
		[Serialize("crossableByLaser"            )] public bool crossableByLaser;
		[Serialize("bounceMultiplier"            )] public float bounceMultiplier;
		[Serialize("bounceVelocity"              )] public float bounceVelocity;
		[Serialize("bounceFire"                  )] public bool bounceFire;
		[Serialize("bounceAcceleration"          )] public float bounceAcceleration;
		[Serialize("trolleySpeed"                )] public float trolleySpeed;
		[Serialize("noWallRun"                   )] public bool noWallRun;
		[Serialize("BounceType"                  )] public Enum_BounceType BounceType;
		[Serialize("bool__0"                     )] public bool bool__0;
		[Serialize("Enum_VH_0__1"                )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("bool__2"                     )] public bool bool__2;
		[Serialize("bool__3"                     )] public bool bool__3;
		[Serialize("bool__4"                     )] public bool bool__4;
		[Serialize("bool__5"                     )] public bool bool__5;
		[Serialize("bool__6"                     )] public bool bool__6;
		[Serialize("bool__7"                     )] public bool bool__7;
		[Serialize("bool__8"                     )] public bool bool__8;
		[Serialize("bool__9"                     )] public bool bool__9;
		[Serialize("bool__10"                    )] public bool bool__10;
		[Serialize("bool__11"                    )] public bool bool__11;
		[Serialize("bool__12"                    )] public bool bool__12;
		[Serialize("bool__13"                    )] public bool bool__13;
		[Serialize("bool__14"                    )] public bool bool__14;
		[Serialize("uint__15"                    )] public uint uint__15;
		[Serialize("float__16"                   )] public float float__16;
		[Serialize("float__17"                   )] public float float__17;
		[Serialize("bool__18"                    )] public bool bool__18;
		[Serialize("float__19"                   )] public float float__19;
		[Serialize("bool__20"                    )] public bool bool__20;
		[Serialize("bool__21"                    )] public bool bool__21;
		[Serialize("bool__22"                    )] public bool bool__22;
		[Serialize("bool__23"                    )] public bool bool__23;
		[Serialize("bool__24"                    )] public bool bool__24;
		[Serialize("bool__25"                    )] public bool bool__25;
		[Serialize("bool__26"                    )] public bool bool__26;
		[Serialize("float__27"                   )] public float float__27;
		[Serialize("float__28"                   )] public float float__28;
		[Serialize("bool__29"                    )] public bool bool__29;
		[Serialize("float__30"                   )] public float float__30;
		[Serialize("float__31"                   )] public float float__31;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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
				SerializeField(s, nameof(castShadow));
				SerializeField(s, nameof(noSquashDamage));
				SerializeField(s, nameof(bounceOnCrushAttack));
				SerializeField(s, nameof(Dangerous));
				SerializeField(s, nameof(movePlatformSpeedXMultiplier));
				SerializeField(s, nameof(movePlatformSpeedYMultiplier));
				SerializeField(s, nameof(shooterBounce));
				SerializeField(s, nameof(djembe));
				SerializeField(s, nameof(wallSlidable));
				SerializeField(s, nameof(wallJumpable));
				SerializeField(s, nameof(noSoftColl));
				SerializeField(s, nameof(noFriendlyFire));
				SerializeField(s, nameof(destroyBoulders));
				SerializeField(s, nameof(crossableByBullet));
				SerializeField(s, nameof(crossableByLaser));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(Enum_VH_0__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(bool__13));
				SerializeField(s, nameof(bool__14));
				SerializeField(s, nameof(uint__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(bool__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(bool__20));
				SerializeField(s, nameof(bool__21));
				SerializeField(s, nameof(bool__22));
				SerializeField(s, nameof(bool__23));
				SerializeField(s, nameof(bool__24));
				SerializeField(s, nameof(bool__25));
				SerializeField(s, nameof(bool__26));
				SerializeField(s, nameof(float__27));
				SerializeField(s, nameof(float__28));
				SerializeField(s, nameof(bool__29));
				SerializeField(s, nameof(float__30));
				SerializeField(s, nameof(float__31));
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
				SerializeField(s, nameof(castShadow));
				SerializeField(s, nameof(noSquashDamage));
				SerializeField(s, nameof(bounceOnCrushAttack));
				SerializeField(s, nameof(Dangerous));
				SerializeField(s, nameof(movePlatformSpeedXMultiplier));
				SerializeField(s, nameof(movePlatformSpeedYMultiplier));
				SerializeField(s, nameof(shooterBounce));
				SerializeField(s, nameof(djembe));
				SerializeField(s, nameof(wallSlidable));
				SerializeField(s, nameof(wallJumpable));
				SerializeField(s, nameof(noSoftColl));
				SerializeField(s, nameof(noFriendlyFire));
				SerializeField(s, nameof(destroyBoulders));
				SerializeField(s, nameof(crossableByBullet));
				SerializeField(s, nameof(crossableByLaser));
				SerializeField(s, nameof(bounceMultiplier));
				SerializeField(s, nameof(bounceVelocity));
				SerializeField(s, nameof(bounceFire));
				SerializeField(s, nameof(bounceAcceleration));
				SerializeField(s, nameof(trolleySpeed));
				SerializeField(s, nameof(noWallRun));
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_NONE"             )] NONE = 0,
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_POLYLINE"         )] POLYLINE = 3,
			[Serialize("BOUNCETYPE_WAVE"             )] WAVE = 4,
			[Serialize("BOUNCETYPE_WINDTUNEL"        )] WINDTUNEL = 5,
			[Serialize("BOUNCETYPE_TALKINGHAT"       )] TALKINGHAT = 6,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
		}
		public enum Enum_BounceType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x56EE53E6;
	}
}

