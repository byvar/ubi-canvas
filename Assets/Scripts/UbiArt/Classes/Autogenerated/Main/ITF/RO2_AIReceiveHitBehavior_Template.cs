using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIReceiveHitBehavior_Template : AIReceiveHitBehavior_Template {
		[Serialize("receiveHits"              )] public CList<RO2_AIReceiveHitBehavior_Template.ReceiveHitData> receiveHits;
		[Serialize("canReceiveRehits"         )] public bool canReceiveRehits;
		[Serialize("hurtDuration"             )] public float hurtDuration;
		[Serialize("maxNumberOfSuccessiveHits")] public uint maxNumberOfSuccessiveHits;
		[Serialize("dominoHitShape"           )] public Generic<PhysShape> dominoHitShape;
		[Serialize("canRehit"                 )] public bool canRehit;
		[Serialize("dominoHitSpeedMultiplier" )] public float dominoHitSpeedMultiplier;
		[Serialize("minHitLevelForDomino"     )] public uint minHitLevelForDomino;
		[Serialize("disableStickOnWallsOnHit" )] public bool disableStickOnWallsOnHit;
		[Serialize("receiveDamageFromDomino"  )] public bool receiveDamageFromDomino;
		[Serialize("canBubblize"              )] public bool canBubblize;
		[Serialize("ceilingAction"            )] public Generic<AIAction_Template> ceilingAction;
		[Serialize("wallAction"               )] public Generic<AIAction_Template> wallAction;
		[Serialize("deathMarkerName"          )] public StringID deathMarkerName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(receiveHits));
			SerializeField(s, nameof(canReceiveRehits));
			SerializeField(s, nameof(hurtDuration));
			SerializeField(s, nameof(maxNumberOfSuccessiveHits));
			SerializeField(s, nameof(dominoHitShape));
			SerializeField(s, nameof(canRehit));
			SerializeField(s, nameof(dominoHitSpeedMultiplier));
			SerializeField(s, nameof(minHitLevelForDomino));
			SerializeField(s, nameof(disableStickOnWallsOnHit));
			SerializeField(s, nameof(receiveDamageFromDomino));
			SerializeField(s, nameof(canBubblize));
			SerializeField(s, nameof(ceilingAction));
			SerializeField(s, nameof(wallAction));
			SerializeField(s, nameof(deathMarkerName));
		}
		[Games(GameFlags.RA)]
		public partial class ReceiveHitData : CSerializable {
			[Serialize("types"          )] public CList<uint> types;
			[Serialize("level"          )] public uint level;
			[Serialize("useIfAlive"     )] public bool useIfAlive;
			[Serialize("useIfDead"      )] public bool useIfDead;
			[Serialize("useIfInAir"     )] public bool useIfInAir;
			[Serialize("useIfOnGround"  )] public bool useIfOnGround;
			[Serialize("isInterruptible")] public bool isInterruptible;
			[Serialize("action"         )] public Generic<AIReceiveHitAction_Template> action;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(types));
				SerializeField(s, nameof(level));
				SerializeField(s, nameof(useIfAlive));
				SerializeField(s, nameof(useIfDead));
				SerializeField(s, nameof(useIfInAir));
				SerializeField(s, nameof(useIfOnGround));
				SerializeField(s, nameof(isInterruptible));
				SerializeField(s, nameof(action));
			}
		}
		public override uint? ClassCRC => 0x3F481226;
	}
}

