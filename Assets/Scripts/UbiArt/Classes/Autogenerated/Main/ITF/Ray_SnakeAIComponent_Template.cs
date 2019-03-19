using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SnakeAIComponent_Template : CSerializable {
		[Serialize("headPolyline"                            )] public StringID headPolyline;
		[Serialize("bodyParts"                               )] public Placeholder bodyParts;
		[Serialize("bodyPartsZSpacing"                       )] public float bodyPartsZSpacing;
		[Serialize("drawHeadBelow"                           )] public int drawHeadBelow;
		[Serialize("gameMaterial"                            )] public Path gameMaterial;
		[Serialize("atlas"                                   )] public Path atlas;
		[Serialize("prevNodeCount"                           )] public uint prevNodeCount;
		[Serialize("sampleLength"                            )] public float sampleLength;
		[Serialize("acceleration"                            )] public float acceleration;
		[Serialize("targetEvaluationOffset"                  )] public Vector2 targetEvaluationOffset;
		[Serialize("speedMultiplierMinDistance"              )] public float speedMultiplierMinDistance;
		[Serialize("speedMultiplierMaxDistance"              )] public float speedMultiplierMaxDistance;
		[Serialize("speedMultiplierMinValue"                 )] public float speedMultiplierMinValue;
		[Serialize("speedMultiplierMaxValue"                 )] public float speedMultiplierMaxValue;
		[Serialize("speedMultiplierAcceleration"             )] public float speedMultiplierAcceleration;
		[Serialize("speedMultiplierDeceleration"             )] public float speedMultiplierDeceleration;
		[Serialize("conciderHeadAsFirstBodyPart"             )] public int conciderHeadAsFirstBodyPart;
		[Serialize("destructibleMode"                        )] public Enum_destructibleMode destructibleMode;
		[Serialize("broadcastHitToPart"                      )] public int broadcastHitToPart;
		[Serialize("broadcastEventToPart"                    )] public int broadcastEventToPart;
		[Serialize("attackMinDistance"                       )] public float attackMinDistance;
		[Serialize("attackMaxDistance"                       )] public float attackMaxDistance;
		[Serialize("deathAnimation"                          )] public StringID deathAnimation;
		[Serialize("attackAnimation"                         )] public StringID attackAnimation;
		[Serialize("deathBhv"                                )] public StringID deathBhv;
		[Serialize("int__0"                                  )] public int int__0;
		[Serialize("int__1"                                  )] public int int__1;
		[Serialize("StringID__2"                             )] public StringID StringID__2;
		[Serialize("CList<Generic<BodyPartBase_Template>>__3")] public CList<Generic<BodyPartBase_Template>> CList_Generic_BodyPartBase_Template__3;
		[Serialize("float__4"                                )] public float float__4;
		[Serialize("int__5"                                  )] public int int__5;
		[Serialize("Path__6"                                 )] public Path Path__6;
		[Serialize("Path__7"                                 )] public Path Path__7;
		[Serialize("uint__8"                                 )] public uint uint__8;
		[Serialize("float__9"                                )] public float float__9;
		[Serialize("float__10"                               )] public float float__10;
		[Serialize("Vector2__11"                             )] public Vector2 Vector2__11;
		[Serialize("float__12"                               )] public float float__12;
		[Serialize("float__13"                               )] public float float__13;
		[Serialize("float__14"                               )] public float float__14;
		[Serialize("float__15"                               )] public float float__15;
		[Serialize("float__16"                               )] public float float__16;
		[Serialize("float__17"                               )] public float float__17;
		[Serialize("int__18"                                 )] public int int__18;
		[Serialize("Enum_RFR_0__19"                          )] public Enum_RFR_0 Enum_RFR_0__19;
		[Serialize("int__20"                                 )] public int int__20;
		[Serialize("int__21"                                 )] public int int__21;
		[Serialize("float__22"                               )] public float float__22;
		[Serialize("float__23"                               )] public float float__23;
		[Serialize("StringID__24"                            )] public StringID StringID__24;
		[Serialize("StringID__25"                            )] public StringID StringID__25;
		[Serialize("StringID__26"                            )] public StringID StringID__26;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(headPolyline));
				SerializeField(s, nameof(bodyParts));
				SerializeField(s, nameof(bodyPartsZSpacing));
				SerializeField(s, nameof(drawHeadBelow));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(atlas));
				SerializeField(s, nameof(prevNodeCount));
				SerializeField(s, nameof(sampleLength));
				SerializeField(s, nameof(acceleration));
				SerializeField(s, nameof(targetEvaluationOffset));
				SerializeField(s, nameof(speedMultiplierMinDistance));
				SerializeField(s, nameof(speedMultiplierMaxDistance));
				SerializeField(s, nameof(speedMultiplierMinValue));
				SerializeField(s, nameof(speedMultiplierMaxValue));
				SerializeField(s, nameof(speedMultiplierAcceleration));
				SerializeField(s, nameof(speedMultiplierDeceleration));
				SerializeField(s, nameof(conciderHeadAsFirstBodyPart));
				SerializeField(s, nameof(destructibleMode));
				SerializeField(s, nameof(broadcastHitToPart));
				SerializeField(s, nameof(broadcastEventToPart));
				SerializeField(s, nameof(attackMinDistance));
				SerializeField(s, nameof(attackMaxDistance));
				SerializeField(s, nameof(deathAnimation));
				SerializeField(s, nameof(attackAnimation));
				SerializeField(s, nameof(deathBhv));
			} else {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(CList_Generic_BodyPartBase_Template__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(Path__6));
				SerializeField(s, nameof(Path__7));
				SerializeField(s, nameof(uint__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(Vector2__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(int__18));
				SerializeField(s, nameof(Enum_RFR_0__19));
				SerializeField(s, nameof(int__20));
				SerializeField(s, nameof(int__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(StringID__24));
				SerializeField(s, nameof(StringID__25));
				SerializeField(s, nameof(StringID__26));
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_destructibleMode {
			[Serialize("None"      )] None = 0,
			[Serialize("FromTail"  )] FromTail = 1,
			[Serialize("PartByPart")] PartByPart = 2,
			[Serialize("TailOnly"  )] TailOnly = 3,
		}
		public override uint? ClassCRC => 0x1449AFA0;
	}
}

