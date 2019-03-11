using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_TriggerBounceComponent_Template : CSerializable {
		[Serialize("phantom"                          )] public Placeholder phantom;
		[Serialize("hurtLevel"                        )] public uint hurtLevel;
		[Serialize("bounceType"                       )] public BOUNCETYPE bounceType;
		[Serialize("faction"                          )] public uint faction;
		[Serialize("retriggerDelay"                   )] public float retriggerDelay;
		[Serialize("idleAnim"                         )] public StringID idleAnim;
		[Serialize("bounceAnim"                       )] public StringID bounceAnim;
		[Serialize("direction"                        )] public Vector2 direction;
		[Serialize("useDirAsWorldAngle"               )] public bool useDirAsWorldAngle;
		[Serialize("stickFruit"                       )] public bool stickFruit;
		[Serialize("sendBounceOnHit"                  )] public bool sendBounceOnHit;
		[Serialize("radial"                           )] public bool radial;
		[Serialize("radialConstrained"                )] public bool radialConstrained;
		[Serialize("height"                           )] public float height;
		[Serialize("height2"                          )] public float height2;
		[Serialize("speed"                            )] public float speed;
		[Serialize("multiplier"                       )] public float multiplier;
		[Serialize("offset"                           )] public Vector2 offset;
		[Serialize("detectRange"                      )] public Angle detectRange;
		[Serialize("sendMoreThanOnce"                 )] public bool sendMoreThanOnce;
		[Serialize("useBounceToPickable"              )] public bool useBounceToPickable;
		[Serialize("useAngleToDiscardBounceToPickable")] public bool useAngleToDiscardBounceToPickable;
		[Serialize("ignoreHitLevel"                   )] public uint ignoreHitLevel;
		[Serialize("blocksHits"                       )] public bool blocksHits;
		[Serialize("disableAtBounce"                  )] public bool disableAtBounce;
		[Serialize("registerToAIManager"              )] public bool registerToAIManager;
		[Serialize("playBounceAnimOnHit"              )] public bool playBounceAnimOnHit;
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

