using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_GameMaterial_Template : GameMaterial_Template {
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
		[Serialize("noSquashDamage"              )] public bool noSquashDamage;
		[Serialize("bounceOnCrushAttack"         )] public bool bounceOnCrushAttack;
		[Serialize("Dangerous"                   )] public uint Dangerous;
		[Serialize("movePlatformSpeedXMultiplier")] public float movePlatformSpeedXMultiplier;
		[Serialize("movePlatformSpeedYMultiplier")] public float movePlatformSpeedYMultiplier;
		[Serialize("shooterBounce"               )] public bool shooterBounce;
		[Serialize("djembe"                      )] public float djembe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_NONE"      )] NONE = 0,
			[Serialize("BOUNCETYPE_ENEMY"     )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"    )] BUMPER = 2,
			[Serialize("BOUNCETYPE_POLYLINE"  )] POLYLINE = 3,
			[Serialize("BOUNCETYPE_WAVE"      )] WAVE = 4,
			[Serialize("BOUNCETYPE_WINDTUNEL" )] WINDTUNEL = 5,
			[Serialize("BOUNCETYPE_TALKINGHAT")] TALKINGHAT = 6,
		}
		public override uint? ClassCRC => 0xA58BAE74;
	}
}

