namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_GameMaterial_Template : GameMaterial_Template {
		public int Bounce;
		public BOUNCETYPE BounceType;
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
		public float float__19;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR) {
				Bounce = s.Serialize<int>(Bounce, name: "Bounce");
				BounceType = s.Serialize<BOUNCETYPE>(BounceType, name: "BounceType");
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
				float__19 = s.Serialize<float>(float__19, name: "float__19");
			} else {
				Bounce = s.Serialize<int>(Bounce, name: "Bounce");
				BounceType = s.Serialize<BOUNCETYPE>(BounceType, name: "BounceType");
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
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_POLYLINE"         )] POLYLINE = 3,
			[Serialize("BOUNCETYPE_WAVE"             )] WAVE = 4,
			[Serialize("BOUNCETYPE_WINDTUNEL"        )] WINDTUNEL = 5,
			[Serialize("BOUNCETYPE_TALKINGHAT"       )] TALKINGHAT = 6,
		}
		public override uint? ClassCRC => 0xA58BAE74;
	}
}

