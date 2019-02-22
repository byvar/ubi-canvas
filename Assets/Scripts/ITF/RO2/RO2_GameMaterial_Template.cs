using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class RO2_GameMaterial_Template : GameMaterial_Template {
		[Serialize(0, "Bounce")] public bool bounce;
		[Serialize(1, "BounceType")] public BounceType bounceType;
		[Serialize(2, "Wave")] public bool Wave;
		[Serialize(3, "climbable")] public bool climbable;
		[Serialize(4, "hangable")] public bool hangable;
		[Serialize(5, "IgnoreCorners")] public bool IgnoreCorners;
		[Serialize(6, "Character")] public bool Character;
		[Serialize(7, "IgnoreLowRoof")] public bool IgnoreLowRoof;
		[Serialize(8, "CanFruitStick")] public bool CanFruitStick;
		[Serialize(9, "climbVertical")] public bool climbVertical;
		[Serialize(10, "climbSlide")] public bool climbSlide;
		[Serialize(11, "climbForceSideJump")] public bool climbForceSideJump;
		[Serialize(12, "castShadow")] public bool RO2_castShadow;
		[Serialize(13, "noSquashDamage")] public bool noSquashDamage;
		[Serialize(14, "bounceOnCrushAttack")] public bool bounceOnCrushAttack;
		[Serialize(15, "Dangerous")] public uint Dangerous;
		[Serialize(16, "movePlatformSpeedXMultiplier")] public float movePlatformSpeedXMultiplier;
		[Serialize(17, "movePlatformSpeedYMultiplier")] public float movePlatformSpeedYMultiplier;
		[Serialize(18, "shooterBounce")] public bool shooterBounce;
		[Serialize(19, "djembe")] public float djembe;
		[Serialize(20, "wallSlidable")] public bool wallSlidable;
		[Serialize(21, "wallJumpable")] public bool wallJumpable;
		[Serialize(22, "noSoftColl")] public bool noSoftColl;
		[Serialize(23, "noFriendlyFire")] public bool noFriendlyFire;
		[Serialize(24, "destroyBoulders")] public bool destroyBoulders;
		[Serialize(25, "crossableByBullet")] public bool crossableByBullet;
		[Serialize(26, "crossableByLaser")] public bool crossableByLaser;
		[Serialize(27, "bounceMultiplier", game = Settings.Game.RA)] public float bounceMultiplier;
		[Serialize(28, "bounceVelocity", game = Settings.Game.RA)] public float bounceVelocity;
		[Serialize(29, "bounceFire", game = Settings.Game.RA)] public bool bounceFire;
		[Serialize(30, "bounceAcceleration", game = Settings.Game.RA)] public float bounceAcceleration;
		[Serialize(31, "trolleySpeed", game = Settings.Game.RA)] public float trolleySpeed;
		[Serialize(32, "noWallRun", game = Settings.Game.RA)] public bool noWallRun;

		public RO2_GameMaterial_Template(Reader reader) : base(reader) {
		}

		public enum BounceType {
			None = 0,
			Enemy,
			Bumper,
			Polyline,
			Wave,
			WindTunel,
			TalkingHat,
			Setbacks,
			AirControl
		}
	}
}
