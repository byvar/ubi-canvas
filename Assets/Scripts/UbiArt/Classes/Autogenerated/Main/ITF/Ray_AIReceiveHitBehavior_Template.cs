using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIReceiveHitBehavior_Template : TemplateAIBehavior {
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
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class ReceiveHitData : CSerializable {
			[Serialize("CArray<uint>__0"                        )] public CArray<uint> CArray_uint__0;
			[Serialize("uint__1"                                )] public uint uint__1;
			[Serialize("int__2"                                 )] public int int__2;
			[Serialize("int__3"                                 )] public int int__3;
			[Serialize("int__4"                                 )] public int int__4;
			[Serialize("int__5"                                 )] public int int__5;
			[Serialize("int__6"                                 )] public int int__6;
			[Serialize("Generic<AIReceiveHitAction_Template>__7")] public Generic<AIReceiveHitAction_Template> Generic_AIReceiveHitAction_Template__7;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(CArray_uint__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(Generic_AIReceiveHitAction_Template__7));
			}
		}
		public override uint? ClassCRC => 0xAA4520A3;
	}
}

