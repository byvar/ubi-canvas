namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIReceiveHitBehavior_Template : AIReceiveHitBehavior_Template {
		public CListO<Ray_AIReceiveHitBehavior_Template.ReceiveHitData> receiveHits;
		public int canReceiveRehits;
		public float hurtDuration;
		public uint maxNumberOfSuccessiveHits;
		public Generic<PhysShape> dominoHitShape;
		public int canRehit;
		public float dominoHitSpeedMultiplier;
		public uint minHitLevelForDomino;
		public int disableStickOnWallsOnHit;
		public int receiveDamageFromDomino;
		public int canBubblize;
		public Generic<AIReceiveHitAction_Template> ceilingAction;
		public Generic<AIReceiveHitAction_Template> wallAction;
		public StringID deathMarkerName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			receiveHits = s.SerializeObject<CListO<Ray_AIReceiveHitBehavior_Template.ReceiveHitData>>(receiveHits, name: "receiveHits");
			canReceiveRehits = s.Serialize<int>(canReceiveRehits, name: "canReceiveRehits");
			hurtDuration = s.Serialize<float>(hurtDuration, name: "hurtDuration");
			maxNumberOfSuccessiveHits = s.Serialize<uint>(maxNumberOfSuccessiveHits, name: "maxNumberOfSuccessiveHits");
			dominoHitShape = s.SerializeObject<Generic<PhysShape>>(dominoHitShape, name: "dominoHitShape");
			canRehit = s.Serialize<int>(canRehit, name: "canRehit");
			dominoHitSpeedMultiplier = s.Serialize<float>(dominoHitSpeedMultiplier, name: "dominoHitSpeedMultiplier");
			minHitLevelForDomino = s.Serialize<uint>(minHitLevelForDomino, name: "minHitLevelForDomino");
			disableStickOnWallsOnHit = s.Serialize<int>(disableStickOnWallsOnHit, name: "disableStickOnWallsOnHit");
			receiveDamageFromDomino = s.Serialize<int>(receiveDamageFromDomino, name: "receiveDamageFromDomino");
			canBubblize = s.Serialize<int>(canBubblize, name: "canBubblize");
			ceilingAction = s.SerializeObject<Generic<AIReceiveHitAction_Template>>(ceilingAction, name: "ceilingAction");
			wallAction = s.SerializeObject<Generic<AIReceiveHitAction_Template>>(wallAction, name: "wallAction");
			deathMarkerName = s.SerializeObject<StringID>(deathMarkerName, name: "deathMarkerName");
		}
		[Games(GameFlags.ROVersion)]
		public partial class ReceiveHitData : CSerializable {
			public CArrayP<uint> types;
			public uint level;
			public int useIfAlive;
			public int useIfDead;
			public int useIfInAir;
			public int useIfOnGround;
			public int isInterruptible;
			public Generic<AIReceiveHitAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				types = s.SerializeObject<CArrayP<uint>>(types, name: "types");
				level = s.Serialize<uint>(level, name: "level");
				useIfAlive = s.Serialize<int>(useIfAlive, name: "useIfAlive");
				useIfDead = s.Serialize<int>(useIfDead, name: "useIfDead");
				useIfInAir = s.Serialize<int>(useIfInAir, name: "useIfInAir");
				useIfOnGround = s.Serialize<int>(useIfOnGround, name: "useIfOnGround");
				isInterruptible = s.Serialize<int>(isInterruptible, name: "isInterruptible");
				action = s.SerializeObject<Generic<AIReceiveHitAction_Template>>(action, name: "action");
			}
		}
		public override uint? ClassCRC => 0xAA4520A3;
	}
}

