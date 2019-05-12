using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIReceiveHitBehavior_Template : AIReceiveHitBehavior_Template {
		[Serialize("receiveHits"              )] public CList<Ray_AIReceiveHitBehavior_Template.ReceiveHitData> receiveHits;
		[Serialize("canReceiveRehits"         )] public int canReceiveRehits;
		[Serialize("hurtDuration"             )] public float hurtDuration;
		[Serialize("maxNumberOfSuccessiveHits")] public uint maxNumberOfSuccessiveHits;
		[Serialize("dominoHitShape"           )] public Generic<PhysShape> dominoHitShape;
		[Serialize("canRehit"                 )] public int canRehit;
		[Serialize("dominoHitSpeedMultiplier" )] public float dominoHitSpeedMultiplier;
		[Serialize("minHitLevelForDomino"     )] public uint minHitLevelForDomino;
		[Serialize("disableStickOnWallsOnHit" )] public int disableStickOnWallsOnHit;
		[Serialize("receiveDamageFromDomino"  )] public int receiveDamageFromDomino;
		[Serialize("canBubblize"              )] public int canBubblize;
		[Serialize("ceilingAction"            )] public Generic<AIReceiveHitAction_Template> ceilingAction;
		[Serialize("wallAction"               )] public Generic<AIReceiveHitAction_Template> wallAction;
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
		[Games(GameFlags.ROVersion)]
		public partial class ReceiveHitData : CSerializable {
			[Serialize("types"          )] public CArray<uint> types;
			[Serialize("level"          )] public uint level;
			[Serialize("useIfAlive"     )] public int useIfAlive;
			[Serialize("useIfDead"      )] public int useIfDead;
			[Serialize("useIfInAir"     )] public int useIfInAir;
			[Serialize("useIfOnGround"  )] public int useIfOnGround;
			[Serialize("isInterruptible")] public int isInterruptible;
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
		public override uint? ClassCRC => 0xAA4520A3;
	}
}

