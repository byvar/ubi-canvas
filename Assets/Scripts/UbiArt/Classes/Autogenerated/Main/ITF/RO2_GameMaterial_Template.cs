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
		[Serialize("castShadow"                  )] public bool castShadow_2;
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
				SerializeField(s, nameof(castShadow_2));
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
				SerializeField(s, nameof(castShadow_2));
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
				SerializeField(s, nameof(castShadow_2));
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
		public override uint? ClassCRC => 0x56EE53E6;
	}
}

