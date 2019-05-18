using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SnakeAIComponent_Template : ActorComponent_Template {
		[Serialize("headPolyline"                            )] public StringID headPolyline;
		[Serialize("bodyParts"                               )] public CList<Generic<BodyPartBase_Template>> bodyParts;
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
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(int__1));
			}
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

