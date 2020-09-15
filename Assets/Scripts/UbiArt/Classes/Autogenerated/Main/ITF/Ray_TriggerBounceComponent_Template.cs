using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_TriggerBounceComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> phantom;
		public uint hurtLevel;
		public BOUNCETYPE bounceType;
		public uint faction;
		public float retriggerDelay;
		public StringID idleAnim;
		public StringID bounceAnim;
		public Vec2d direction;
		public int useDirAsWorldAngle;
		public int stickFruit;
		public int sendBounceOnHit;
		public int radial;
		public int radialConstrained;
		public float height;
		public float height2;
		public float speed;
		public float multiplier;
		public Vec2d offset;
		public Angle detectRange;
		public int sendMoreThanOnce;
		public int useBounceToPickable;
		public int useAngleToDiscardBounceToPickable;
		public uint ignoreHitLevel;
		public int blocksHits;
		public int disableAtBounce;
		public int registerToAIManager;
		public int playBounceAnimOnHit;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			phantom = s.SerializeObject<Generic<PhysShape>>(phantom, name: "phantom");
			hurtLevel = s.Serialize<uint>(hurtLevel, name: "hurtLevel");
			bounceType = s.Serialize<BOUNCETYPE>(bounceType, name: "bounceType");
			faction = s.Serialize<uint>(faction, name: "faction");
			retriggerDelay = s.Serialize<float>(retriggerDelay, name: "retriggerDelay");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			bounceAnim = s.SerializeObject<StringID>(bounceAnim, name: "bounceAnim");
			direction = s.SerializeObject<Vec2d>(direction, name: "direction");
			useDirAsWorldAngle = s.Serialize<int>(useDirAsWorldAngle, name: "useDirAsWorldAngle");
			stickFruit = s.Serialize<int>(stickFruit, name: "stickFruit");
			sendBounceOnHit = s.Serialize<int>(sendBounceOnHit, name: "sendBounceOnHit");
			radial = s.Serialize<int>(radial, name: "radial");
			radialConstrained = s.Serialize<int>(radialConstrained, name: "radialConstrained");
			height = s.Serialize<float>(height, name: "height");
			height2 = s.Serialize<float>(height2, name: "height2");
			speed = s.Serialize<float>(speed, name: "speed");
			multiplier = s.Serialize<float>(multiplier, name: "multiplier");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			detectRange = s.SerializeObject<Angle>(detectRange, name: "detectRange");
			sendMoreThanOnce = s.Serialize<int>(sendMoreThanOnce, name: "sendMoreThanOnce");
			useBounceToPickable = s.Serialize<int>(useBounceToPickable, name: "useBounceToPickable");
			useAngleToDiscardBounceToPickable = s.Serialize<int>(useAngleToDiscardBounceToPickable, name: "useAngleToDiscardBounceToPickable");
			ignoreHitLevel = s.Serialize<uint>(ignoreHitLevel, name: "ignoreHitLevel");
			blocksHits = s.Serialize<int>(blocksHits, name: "blocksHits");
			disableAtBounce = s.Serialize<int>(disableAtBounce, name: "disableAtBounce");
			registerToAIManager = s.Serialize<int>(registerToAIManager, name: "registerToAIManager");
			playBounceAnimOnHit = s.Serialize<int>(playBounceAnimOnHit, name: "playBounceAnimOnHit");
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY" )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER")] BUMPER = 2,
		}
		public override uint? ClassCRC => 0x21368B71;
	}
}

