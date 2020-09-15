using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_TriggerBounceComponent_Template : ActorComponent_Template {
		[Serialize("phantom"                          )] public Generic<PhysShape> phantom;
		[Serialize("hurtLevel"                        )] public uint hurtLevel;
		[Serialize("bounceType"                       )] public BOUNCETYPE bounceType;
		[Serialize("faction"                          )] public uint faction;
		[Serialize("retriggerDelay"                   )] public float retriggerDelay;
		[Serialize("idleAnim"                         )] public StringID idleAnim;
		[Serialize("bounceAnim"                       )] public StringID bounceAnim;
		[Serialize("direction"                        )] public Vec2d direction;
		[Serialize("useDirAsWorldAngle"               )] public int useDirAsWorldAngle;
		[Serialize("stickFruit"                       )] public int stickFruit;
		[Serialize("sendBounceOnHit"                  )] public int sendBounceOnHit;
		[Serialize("radial"                           )] public int radial;
		[Serialize("radialConstrained"                )] public int radialConstrained;
		[Serialize("height"                           )] public float height;
		[Serialize("height2"                          )] public float height2;
		[Serialize("speed"                            )] public float speed;
		[Serialize("multiplier"                       )] public float multiplier;
		[Serialize("offset"                           )] public Vec2d offset;
		[Serialize("detectRange"                      )] public Angle detectRange;
		[Serialize("sendMoreThanOnce"                 )] public int sendMoreThanOnce;
		[Serialize("useBounceToPickable"              )] public int useBounceToPickable;
		[Serialize("useAngleToDiscardBounceToPickable")] public int useAngleToDiscardBounceToPickable;
		[Serialize("ignoreHitLevel"                   )] public uint ignoreHitLevel;
		[Serialize("blocksHits"                       )] public int blocksHits;
		[Serialize("disableAtBounce"                  )] public int disableAtBounce;
		[Serialize("registerToAIManager"              )] public int registerToAIManager;
		[Serialize("playBounceAnimOnHit"              )] public int playBounceAnimOnHit;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(phantom));
			SerializeField(s, nameof(hurtLevel));
			SerializeField(s, nameof(bounceType));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(retriggerDelay));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(bounceAnim));
			SerializeField(s, nameof(direction));
			SerializeField(s, nameof(useDirAsWorldAngle));
			SerializeField(s, nameof(stickFruit));
			SerializeField(s, nameof(sendBounceOnHit));
			SerializeField(s, nameof(radial));
			SerializeField(s, nameof(radialConstrained));
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(height2));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(multiplier));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(detectRange));
			SerializeField(s, nameof(sendMoreThanOnce));
			SerializeField(s, nameof(useBounceToPickable));
			SerializeField(s, nameof(useAngleToDiscardBounceToPickable));
			SerializeField(s, nameof(ignoreHitLevel));
			SerializeField(s, nameof(blocksHits));
			SerializeField(s, nameof(disableAtBounce));
			SerializeField(s, nameof(registerToAIManager));
			SerializeField(s, nameof(playBounceAnimOnHit));
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY" )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER")] BUMPER = 2,
		}
		public override uint? ClassCRC => 0x21368B71;
	}
}

