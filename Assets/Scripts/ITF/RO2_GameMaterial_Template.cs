using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class RO2_GameMaterial_Template : GameMaterial_Template {
		public bool bounce;
		public BounceType bounceType;
		public bool Wave;
		public bool climbable;
		public bool hangable;
		public bool IgnoreCorners;
		public bool Character;
		public bool IgnoreLowRoof;
		public bool CanFruitStick;
		public bool climbVertical;
		public bool climbSlide;
		public bool climbForceSideJump;
		public bool RO2_castShadow;
		public bool noSquashDamage;
		public bool bounceOnCrushAttack;
		public uint Dangerous;
		public float movePlatformSpeedXMultiplier;
		public float movePlatformSpeedYMultiplier;
		public bool shooterBounce;
		public float djembe;
		public bool wallSlidable;
		public bool wallJumpable;
		public bool noSoftColl;
		public bool noFriendlyFire;
		public bool destroyBoulders;
		public bool crossableByBullet;
		public bool crossableByLaser;
		public float bounceMultiplier;
		public float bounceVelocity;
		public bool bounceFire;
		public float bounceAcceleration;
		public float trolleySpeed;
		public bool noWallRun;

		public RO2_GameMaterial_Template(Reader reader) : base(reader) {
			bounce = reader.ReadBoolean();
			bounceType = (BounceType)reader.ReadUInt32();
			Wave = reader.ReadBoolean();
			climbable = reader.ReadBoolean();
			hangable = reader.ReadBoolean();
			IgnoreCorners = reader.ReadBoolean();
			Character = reader.ReadBoolean();
			IgnoreLowRoof = reader.ReadBoolean();
			CanFruitStick = reader.ReadBoolean();
			climbVertical = reader.ReadBoolean();
			climbSlide = reader.ReadBoolean();
			climbForceSideJump = reader.ReadBoolean();
			castShadow = reader.ReadBoolean();
			noSquashDamage = reader.ReadBoolean();
			bounceOnCrushAttack = reader.ReadBoolean();
			Dangerous = reader.ReadUInt32();
			movePlatformSpeedXMultiplier = reader.ReadSingle();
			movePlatformSpeedYMultiplier = reader.ReadSingle();
			shooterBounce = reader.ReadBoolean();
			djembe = reader.ReadSingle();
			wallSlidable = reader.ReadBoolean();
			wallJumpable = reader.ReadBoolean();
			noSoftColl = reader.ReadBoolean();
			noFriendlyFire = reader.ReadBoolean();
			destroyBoulders = reader.ReadBoolean();
			crossableByBullet = reader.ReadBoolean();
			crossableByLaser = reader.ReadBoolean();
			if (Settings.s.game == Settings.Game.RA) {
				bounceMultiplier = reader.ReadSingle();
				bounceVelocity = reader.ReadSingle();
				bounceFire = reader.ReadBoolean();
				bounceAcceleration = reader.ReadSingle();
				trolleySpeed = reader.ReadSingle();
				noWallRun = reader.ReadBoolean();
			}
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
