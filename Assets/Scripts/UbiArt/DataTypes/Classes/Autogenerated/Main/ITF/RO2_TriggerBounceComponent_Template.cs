namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_TriggerBounceComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> phantom;
		public uint hurtLevel;
		public BOUNCETYPE bounceType = BOUNCETYPE.BUMPER;
		public uint faction = uint.MaxValue;
		public float retriggerDelay = 1f;
		public StringID idleAnim;
		public StringID bounceAnim;
		public Vec2d direction = Vec2d.Up;
		public bool useDirAsWorldAngle;
		public bool sendBounceOnHit;
		public bool radial;
		public bool radialConstrained;
		public float height = 3f;
		public float height2 = 2f;
		public float bounceToActorSpecificSpeed = -1f;
		public bool useBounceHeight;
		public float speed = 7f;
		public float multiplier = 1f;
		public Vec2d offset;
		public Angle detectRange;
		public bool sendMoreThanOnce;
		public bool useBounceToPickable = true;
		public bool useAngleToDiscardBounceToPickable;
		public uint ignoreHitLevel = 1;
		public bool blocksHits;
		public bool disableAtBounce;
		public bool registerToAIManager = true;
		public bool playBounceAnimOnHit = true;
		public bool useActorPosForBounce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				phantom = s.SerializeObject<Generic<PhysShape>>(phantom, name: "phantom");
				hurtLevel = s.Serialize<uint>(hurtLevel, name: "hurtLevel");
				bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
				faction = s.Serialize<uint>(faction, name: "faction");
				retriggerDelay = s.Serialize<float>(retriggerDelay, name: "retriggerDelay");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				bounceAnim = s.SerializeObject<StringID>(bounceAnim, name: "bounceAnim");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				useDirAsWorldAngle = s.Serialize<bool>(useDirAsWorldAngle, name: "useDirAsWorldAngle");
				sendBounceOnHit = s.Serialize<bool>(sendBounceOnHit, name: "sendBounceOnHit");
				radial = s.Serialize<bool>(radial, name: "radial");
				radialConstrained = s.Serialize<bool>(radialConstrained, name: "radialConstrained");
				height = s.Serialize<float>(height, name: "height");
				height2 = s.Serialize<float>(height2, name: "height2");
				bounceToActorSpecificSpeed = s.Serialize<float>(bounceToActorSpecificSpeed, name: "bounceToActorSpecificSpeed");
				useBounceHeight = s.Serialize<bool>(useBounceHeight, name: "useBounceHeight");
				speed = s.Serialize<float>(speed, name: "speed");
				multiplier = s.Serialize<float>(multiplier, name: "multiplier");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				detectRange = s.SerializeObject<Angle>(detectRange, name: "detectRange");
				sendMoreThanOnce = s.Serialize<bool>(sendMoreThanOnce, name: "sendMoreThanOnce");
				useBounceToPickable = s.Serialize<bool>(useBounceToPickable, name: "useBounceToPickable");
				useAngleToDiscardBounceToPickable = s.Serialize<bool>(useAngleToDiscardBounceToPickable, name: "useAngleToDiscardBounceToPickable");
				ignoreHitLevel = s.Serialize<uint>(ignoreHitLevel, name: "ignoreHitLevel");
				blocksHits = s.Serialize<bool>(blocksHits, name: "blocksHits");
				disableAtBounce = s.Serialize<bool>(disableAtBounce, name: "disableAtBounce");
				registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
				playBounceAnimOnHit = s.Serialize<bool>(playBounceAnimOnHit, name: "playBounceAnimOnHit");
				useActorPosForBounce = s.Serialize<bool>(useActorPosForBounce, name: "useActorPosForBounce");
			} else {
				phantom = s.SerializeObject<Generic<PhysShape>>(phantom, name: "phantom");
				hurtLevel = s.Serialize<uint>(hurtLevel, name: "hurtLevel");
				bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
				faction = s.Serialize<uint>(faction, name: "faction");
				retriggerDelay = s.Serialize<float>(retriggerDelay, name: "retriggerDelay");
				idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
				bounceAnim = s.SerializeObject<StringID>(bounceAnim, name: "bounceAnim");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				useDirAsWorldAngle = s.Serialize<bool>(useDirAsWorldAngle, name: "useDirAsWorldAngle");
				sendBounceOnHit = s.Serialize<bool>(sendBounceOnHit, name: "sendBounceOnHit");
				radial = s.Serialize<bool>(radial, name: "radial");
				radialConstrained = s.Serialize<bool>(radialConstrained, name: "radialConstrained");
				height = s.Serialize<float>(height, name: "height");
				height2 = s.Serialize<float>(height2, name: "height2");
				bounceToActorSpecificSpeed = s.Serialize<float>(bounceToActorSpecificSpeed, name: "bounceToActorSpecificSpeed");
				useBounceHeight = s.Serialize<bool>(useBounceHeight, name: "useBounceHeight");
				speed = s.Serialize<float>(speed, name: "speed");
				multiplier = s.Serialize<float>(multiplier, name: "multiplier");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
				detectRange = s.SerializeObject<Angle>(detectRange, name: "detectRange");
				sendMoreThanOnce = s.Serialize<bool>(sendMoreThanOnce, name: "sendMoreThanOnce");
				useBounceToPickable = s.Serialize<bool>(useBounceToPickable, name: "useBounceToPickable");
				useAngleToDiscardBounceToPickable = s.Serialize<bool>(useAngleToDiscardBounceToPickable, name: "useAngleToDiscardBounceToPickable");
				ignoreHitLevel = s.Serialize<uint>(ignoreHitLevel, name: "ignoreHitLevel");
				blocksHits = s.Serialize<bool>(blocksHits, name: "blocksHits");
				disableAtBounce = s.Serialize<bool>(disableAtBounce, name: "disableAtBounce");
				registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
				playBounceAnimOnHit = s.Serialize<bool>(playBounceAnimOnHit, name: "playBounceAnimOnHit");
				useActorPosForBounce = s.Serialize<bool>(useActorPosForBounce, name: "useActorPosForBounce");
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public override uint? ClassCRC => 0x542A5D77;
	}
}

