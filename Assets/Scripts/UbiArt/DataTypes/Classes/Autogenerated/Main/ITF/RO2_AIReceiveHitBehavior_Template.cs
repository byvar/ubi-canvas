namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIReceiveHitBehavior_Template : AIReceiveHitBehavior_Template {
		public CListO<RO2_AIReceiveHitBehavior_Template.ReceiveHitData> receiveHits;
		public bool canReceiveRehits = true;
		public float hurtDuration = 0.5f;
		public uint maxNumberOfSuccessiveHits = 5;
		public Generic<PhysShape> dominoHitShape;
		public bool canRehit;
		public float dominoHitSpeedMultiplier = 0.2f;
		public uint minHitLevelForDomino = 1;
		public bool disableStickOnWallsOnHit;
		public bool receiveDamageFromDomino = true;
		public bool canBubblize = true;
		public Generic<AIAction_Template> ceilingAction;
		public Generic<AIAction_Template> wallAction;
		public StringID deathMarkerName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			receiveHits = s.SerializeObject<CListO<RO2_AIReceiveHitBehavior_Template.ReceiveHitData>>(receiveHits, name: "receiveHits");
			canReceiveRehits = s.Serialize<bool>(canReceiveRehits, name: "canReceiveRehits");
			hurtDuration = s.Serialize<float>(hurtDuration, name: "hurtDuration");
			maxNumberOfSuccessiveHits = s.Serialize<uint>(maxNumberOfSuccessiveHits, name: "maxNumberOfSuccessiveHits");
			dominoHitShape = s.SerializeObject<Generic<PhysShape>>(dominoHitShape, name: "dominoHitShape");
			canRehit = s.Serialize<bool>(canRehit, name: "canRehit");
			dominoHitSpeedMultiplier = s.Serialize<float>(dominoHitSpeedMultiplier, name: "dominoHitSpeedMultiplier");
			minHitLevelForDomino = s.Serialize<uint>(minHitLevelForDomino, name: "minHitLevelForDomino");
			disableStickOnWallsOnHit = s.Serialize<bool>(disableStickOnWallsOnHit, name: "disableStickOnWallsOnHit");
			receiveDamageFromDomino = s.Serialize<bool>(receiveDamageFromDomino, name: "receiveDamageFromDomino");
			canBubblize = s.Serialize<bool>(canBubblize, name: "canBubblize");
			ceilingAction = s.SerializeObject<Generic<AIAction_Template>>(ceilingAction, name: "ceilingAction");
			wallAction = s.SerializeObject<Generic<AIAction_Template>>(wallAction, name: "wallAction");
			deathMarkerName = s.SerializeObject<StringID>(deathMarkerName, name: "deathMarkerName");
		}
		[Games(GameFlags.RA)]
		public partial class ReceiveHitData : CSerializable {
			public CListP<uint> types;
			public uint level;
			public bool useIfAlive;
			public bool useIfDead;
			public bool useIfInAir;
			public bool useIfOnGround;
			public bool isInterruptible;
			public Generic<AIReceiveHitAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				types = s.SerializeObject<CListP<uint>>(types, name: "types");
				level = s.Serialize<uint>(level, name: "level");
				useIfAlive = s.Serialize<bool>(useIfAlive, name: "useIfAlive");
				useIfDead = s.Serialize<bool>(useIfDead, name: "useIfDead");
				useIfInAir = s.Serialize<bool>(useIfInAir, name: "useIfInAir");
				useIfOnGround = s.Serialize<bool>(useIfOnGround, name: "useIfOnGround");
				isInterruptible = s.Serialize<bool>(isInterruptible, name: "isInterruptible");
				action = s.SerializeObject<Generic<AIReceiveHitAction_Template>>(action, name: "action");
			}
		}
		public override uint? ClassCRC => 0x3F481226;
	}
}

