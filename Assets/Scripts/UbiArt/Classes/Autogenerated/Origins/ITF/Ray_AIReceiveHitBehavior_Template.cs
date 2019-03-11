using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIReceiveHitBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("receiveHits"              )] public Placeholder receiveHits;
		[Serialize("canReceiveRehits"         )] public bool canReceiveRehits;
		[Serialize("hurtDuration"             )] public float hurtDuration;
		[Serialize("maxNumberOfSuccessiveHits")] public uint maxNumberOfSuccessiveHits;
		[Serialize("dominoHitShape"           )] public Placeholder dominoHitShape;
		[Serialize("canRehit"                 )] public bool canRehit;
		[Serialize("dominoHitSpeedMultiplier" )] public float dominoHitSpeedMultiplier;
		[Serialize("minHitLevelForDomino"     )] public uint minHitLevelForDomino;
		[Serialize("disableStickOnWallsOnHit" )] public bool disableStickOnWallsOnHit;
		[Serialize("receiveDamageFromDomino"  )] public bool receiveDamageFromDomino;
		[Serialize("canBubblize"              )] public bool canBubblize;
		[Serialize("ceilingAction"            )] public Placeholder ceilingAction;
		[Serialize("wallAction"               )] public Placeholder wallAction;
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
		public override uint? ClassCRC => 0xAA4520A3;
	}
}

