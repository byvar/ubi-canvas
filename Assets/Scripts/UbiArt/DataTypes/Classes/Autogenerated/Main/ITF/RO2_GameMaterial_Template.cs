namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_GameMaterial_Template : GameMaterial_Template {
		public bool Bounce;
		public BOUNCETYPE BounceType;
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
		public bool castShadow_2;
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
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				Bounce = s.Serialize<bool>(Bounce, name: "Bounce");
				BounceType = s.Serialize<BOUNCETYPE>(BounceType, name: "BounceType");
				Wave = s.Serialize<bool>(Wave, name: "Wave");
				climbable = s.Serialize<bool>(climbable, name: "climbable");
				hangable = s.Serialize<bool>(hangable, name: "hangable");
				IgnoreCorners = s.Serialize<bool>(IgnoreCorners, name: "IgnoreCorners");
				Character = s.Serialize<bool>(Character, name: "Character");
				IgnoreLowRoof = s.Serialize<bool>(IgnoreLowRoof, name: "IgnoreLowRoof");
				CanFruitStick = s.Serialize<bool>(CanFruitStick, name: "CanFruitStick");
				climbVertical = s.Serialize<bool>(climbVertical, name: "climbVertical");
				climbSlide = s.Serialize<bool>(climbSlide, name: "climbSlide");
				climbForceSideJump = s.Serialize<bool>(climbForceSideJump, name: "climbForceSideJump");
				castShadow_2 = s.Serialize<bool>(castShadow_2, name: "castShadow");
				noSquashDamage = s.Serialize<bool>(noSquashDamage, name: "noSquashDamage");
				bounceOnCrushAttack = s.Serialize<bool>(bounceOnCrushAttack, name: "bounceOnCrushAttack");
				Dangerous = s.Serialize<uint>(Dangerous, name: "Dangerous");
				movePlatformSpeedXMultiplier = s.Serialize<float>(movePlatformSpeedXMultiplier, name: "movePlatformSpeedXMultiplier");
				movePlatformSpeedYMultiplier = s.Serialize<float>(movePlatformSpeedYMultiplier, name: "movePlatformSpeedYMultiplier");
				shooterBounce = s.Serialize<bool>(shooterBounce, name: "shooterBounce");
				djembe = s.Serialize<float>(djembe, name: "djembe");
				wallSlidable = s.Serialize<bool>(wallSlidable, name: "wallSlidable");
				wallJumpable = s.Serialize<bool>(wallJumpable, name: "wallJumpable");
				noSoftColl = s.Serialize<bool>(noSoftColl, name: "noSoftColl");
				noFriendlyFire = s.Serialize<bool>(noFriendlyFire, name: "noFriendlyFire");
				destroyBoulders = s.Serialize<bool>(destroyBoulders, name: "destroyBoulders");
				crossableByBullet = s.Serialize<bool>(crossableByBullet, name: "crossableByBullet");
				crossableByLaser = s.Serialize<bool>(crossableByLaser, name: "crossableByLaser");
			} else if (s.Settings.game == Settings.Game.VH) {
				Bounce = s.Serialize<bool>(Bounce, name: "Bounce");
				BounceType = s.Serialize<BOUNCETYPE>(BounceType, name: "BounceType");
				Wave = s.Serialize<bool>(Wave, name: "Wave");
				climbable = s.Serialize<bool>(climbable, name: "climbable");
				hangable = s.Serialize<bool>(hangable, name: "hangable");
				IgnoreCorners = s.Serialize<bool>(IgnoreCorners, name: "IgnoreCorners");
				Character = s.Serialize<bool>(Character, name: "Character");
				IgnoreLowRoof = s.Serialize<bool>(IgnoreLowRoof, name: "IgnoreLowRoof");
				CanFruitStick = s.Serialize<bool>(CanFruitStick, name: "CanFruitStick");
				climbVertical = s.Serialize<bool>(climbVertical, name: "climbVertical");
				climbSlide = s.Serialize<bool>(climbSlide, name: "climbSlide");
				climbForceSideJump = s.Serialize<bool>(climbForceSideJump, name: "climbForceSideJump");
				castShadow_2 = s.Serialize<bool>(castShadow_2, name: "castShadow");
				noSquashDamage = s.Serialize<bool>(noSquashDamage, name: "noSquashDamage");
				bounceOnCrushAttack = s.Serialize<bool>(bounceOnCrushAttack, name: "bounceOnCrushAttack");
				Dangerous = s.Serialize<uint>(Dangerous, name: "Dangerous");
				movePlatformSpeedXMultiplier = s.Serialize<float>(movePlatformSpeedXMultiplier, name: "movePlatformSpeedXMultiplier");
				movePlatformSpeedYMultiplier = s.Serialize<float>(movePlatformSpeedYMultiplier, name: "movePlatformSpeedYMultiplier");
				shooterBounce = s.Serialize<bool>(shooterBounce, name: "shooterBounce");
				djembe = s.Serialize<float>(djembe, name: "djembe");
				wallSlidable = s.Serialize<bool>(wallSlidable, name: "wallSlidable");
				wallJumpable = s.Serialize<bool>(wallJumpable, name: "wallJumpable");
				noSoftColl = s.Serialize<bool>(noSoftColl, name: "noSoftColl");
				noFriendlyFire = s.Serialize<bool>(noFriendlyFire, name: "noFriendlyFire");
				destroyBoulders = s.Serialize<bool>(destroyBoulders, name: "destroyBoulders");
				crossableByBullet = s.Serialize<bool>(crossableByBullet, name: "crossableByBullet");
				crossableByLaser = s.Serialize<bool>(crossableByLaser, name: "crossableByLaser");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
				bounceVelocity = s.Serialize<float>(bounceVelocity, name: "bounceVelocity");
				bounceFire = s.Serialize<bool>(bounceFire, name: "bounceFire");
				bounceAcceleration = s.Serialize<float>(bounceAcceleration, name: "bounceAcceleration");
				trolleySpeed = s.Serialize<float>(trolleySpeed, name: "trolleySpeed");
			} else {
				Bounce = s.Serialize<bool>(Bounce, name: "Bounce");
				BounceType = s.Serialize<BOUNCETYPE>(BounceType, name: "BounceType");
				Wave = s.Serialize<bool>(Wave, name: "Wave");
				climbable = s.Serialize<bool>(climbable, name: "climbable");
				hangable = s.Serialize<bool>(hangable, name: "hangable");
				IgnoreCorners = s.Serialize<bool>(IgnoreCorners, name: "IgnoreCorners");
				Character = s.Serialize<bool>(Character, name: "Character");
				IgnoreLowRoof = s.Serialize<bool>(IgnoreLowRoof, name: "IgnoreLowRoof");
				CanFruitStick = s.Serialize<bool>(CanFruitStick, name: "CanFruitStick");
				climbVertical = s.Serialize<bool>(climbVertical, name: "climbVertical");
				climbSlide = s.Serialize<bool>(climbSlide, name: "climbSlide");
				climbForceSideJump = s.Serialize<bool>(climbForceSideJump, name: "climbForceSideJump");
				castShadow_2 = s.Serialize<bool>(castShadow_2, name: "castShadow");
				noSquashDamage = s.Serialize<bool>(noSquashDamage, name: "noSquashDamage");
				bounceOnCrushAttack = s.Serialize<bool>(bounceOnCrushAttack, name: "bounceOnCrushAttack");
				Dangerous = s.Serialize<uint>(Dangerous, name: "Dangerous");
				movePlatformSpeedXMultiplier = s.Serialize<float>(movePlatformSpeedXMultiplier, name: "movePlatformSpeedXMultiplier");
				movePlatformSpeedYMultiplier = s.Serialize<float>(movePlatformSpeedYMultiplier, name: "movePlatformSpeedYMultiplier");
				shooterBounce = s.Serialize<bool>(shooterBounce, name: "shooterBounce");
				djembe = s.Serialize<float>(djembe, name: "djembe");
				wallSlidable = s.Serialize<bool>(wallSlidable, name: "wallSlidable");
				wallJumpable = s.Serialize<bool>(wallJumpable, name: "wallJumpable");
				noSoftColl = s.Serialize<bool>(noSoftColl, name: "noSoftColl");
				noFriendlyFire = s.Serialize<bool>(noFriendlyFire, name: "noFriendlyFire");
				destroyBoulders = s.Serialize<bool>(destroyBoulders, name: "destroyBoulders");
				crossableByBullet = s.Serialize<bool>(crossableByBullet, name: "crossableByBullet");
				crossableByLaser = s.Serialize<bool>(crossableByLaser, name: "crossableByLaser");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
				bounceVelocity = s.Serialize<float>(bounceVelocity, name: "bounceVelocity");
				bounceFire = s.Serialize<bool>(bounceFire, name: "bounceFire");
				bounceAcceleration = s.Serialize<float>(bounceAcceleration, name: "bounceAcceleration");
				trolleySpeed = s.Serialize<float>(trolleySpeed, name: "trolleySpeed");
				noWallRun = s.Serialize<bool>(noWallRun, name: "noWallRun");
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

