using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TriggerBounceComponent_Template : ActorComponent_Template {
		[Serialize("phantom"                          )] public Generic<PhysShape> phantom;
		[Serialize("hurtLevel"                        )] public uint hurtLevel;
		[Serialize("bounceType"                       )] public BOUNCETYPE bounceType;
		[Serialize("faction"                          )] public uint faction;
		[Serialize("retriggerDelay"                   )] public float retriggerDelay;
		[Serialize("idleAnim"                         )] public StringID idleAnim;
		[Serialize("bounceAnim"                       )] public StringID bounceAnim;
		[Serialize("direction"                        )] public Vector2 direction;
		[Serialize("useDirAsWorldAngle"               )] public bool useDirAsWorldAngle;
		[Serialize("sendBounceOnHit"                  )] public bool sendBounceOnHit;
		[Serialize("radial"                           )] public bool radial;
		[Serialize("radialConstrained"                )] public bool radialConstrained;
		[Serialize("height"                           )] public float height;
		[Serialize("height2"                          )] public float height2;
		[Serialize("bounceToActorSpecificSpeed"       )] public float bounceToActorSpecificSpeed;
		[Serialize("useBounceHeight"                  )] public bool useBounceHeight;
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
		[Serialize("useActorPosForBounce"             )] public bool useActorPosForBounce;
		[Serialize("bounceType"                       )] public Enum_bounceType bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(hurtLevel));
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(retriggerDelay));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(bounceAnim));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(useDirAsWorldAngle));
				SerializeField(s, nameof(sendBounceOnHit));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(radialConstrained));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(height2));
				SerializeField(s, nameof(bounceToActorSpecificSpeed));
				SerializeField(s, nameof(useBounceHeight));
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
				SerializeField(s, nameof(useActorPosForBounce));
			} else {
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(hurtLevel));
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(retriggerDelay));
				SerializeField(s, nameof(idleAnim));
				SerializeField(s, nameof(bounceAnim));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(useDirAsWorldAngle));
				SerializeField(s, nameof(sendBounceOnHit));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(radialConstrained));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(height2));
				SerializeField(s, nameof(bounceToActorSpecificSpeed));
				SerializeField(s, nameof(useBounceHeight));
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
				SerializeField(s, nameof(useActorPosForBounce));
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public enum Enum_bounceType {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x542A5D77;
	}
}

