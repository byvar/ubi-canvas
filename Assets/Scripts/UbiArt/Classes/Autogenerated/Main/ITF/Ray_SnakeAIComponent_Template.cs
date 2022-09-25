using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_SnakeAIComponent_Template : ActorComponent_Template {
		public StringID headPolyline;
		public CListO<Generic<BodyPartBase_Template>> bodyParts;
		public float bodyPartsZSpacing;
		public int drawHeadBelow;
		public Path gameMaterial;
		public Path atlas;
		public uint prevNodeCount;
		public float sampleLength;
		public float acceleration;
		public Vec2d targetEvaluationOffset;
		public float speedMultiplierMinDistance;
		public float speedMultiplierMaxDistance;
		public float speedMultiplierMinValue;
		public float speedMultiplierMaxValue;
		public float speedMultiplierAcceleration;
		public float speedMultiplierDeceleration;
		public int conciderHeadAsFirstBodyPart;
		public Enum_destructibleMode destructibleMode;
		public int broadcastHitToPart;
		public int broadcastEventToPart;
		public float attackMinDistance;
		public float attackMaxDistance;
		public StringID deathAnimation;
		public StringID attackAnimation;
		public StringID deathBhv;
		public int int__0;
		public int int__1;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				int__0 = s.Serialize<int>(int__0, name: "int__0");
				int__1 = s.Serialize<int>(int__1, name: "int__1");
			}
			headPolyline = s.SerializeObject<StringID>(headPolyline, name: "headPolyline");
			bodyParts = s.SerializeObject<CListO<Generic<BodyPartBase_Template>>>(bodyParts, name: "bodyParts");
			bodyPartsZSpacing = s.Serialize<float>(bodyPartsZSpacing, name: "bodyPartsZSpacing");
			drawHeadBelow = s.Serialize<int>(drawHeadBelow, name: "drawHeadBelow");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			atlas = s.SerializeObject<Path>(atlas, name: "atlas");
			prevNodeCount = s.Serialize<uint>(prevNodeCount, name: "prevNodeCount");
			sampleLength = s.Serialize<float>(sampleLength, name: "sampleLength");
			acceleration = s.Serialize<float>(acceleration, name: "acceleration");
			targetEvaluationOffset = s.SerializeObject<Vec2d>(targetEvaluationOffset, name: "targetEvaluationOffset");
			speedMultiplierMinDistance = s.Serialize<float>(speedMultiplierMinDistance, name: "speedMultiplierMinDistance");
			speedMultiplierMaxDistance = s.Serialize<float>(speedMultiplierMaxDistance, name: "speedMultiplierMaxDistance");
			speedMultiplierMinValue = s.Serialize<float>(speedMultiplierMinValue, name: "speedMultiplierMinValue");
			speedMultiplierMaxValue = s.Serialize<float>(speedMultiplierMaxValue, name: "speedMultiplierMaxValue");
			speedMultiplierAcceleration = s.Serialize<float>(speedMultiplierAcceleration, name: "speedMultiplierAcceleration");
			speedMultiplierDeceleration = s.Serialize<float>(speedMultiplierDeceleration, name: "speedMultiplierDeceleration");
			conciderHeadAsFirstBodyPart = s.Serialize<int>(conciderHeadAsFirstBodyPart, name: "conciderHeadAsFirstBodyPart");
			destructibleMode = s.Serialize<Enum_destructibleMode>(destructibleMode, name: "destructibleMode");
			broadcastHitToPart = s.Serialize<int>(broadcastHitToPart, name: "broadcastHitToPart");
			broadcastEventToPart = s.Serialize<int>(broadcastEventToPart, name: "broadcastEventToPart");
			attackMinDistance = s.Serialize<float>(attackMinDistance, name: "attackMinDistance");
			attackMaxDistance = s.Serialize<float>(attackMaxDistance, name: "attackMaxDistance");
			deathAnimation = s.SerializeObject<StringID>(deathAnimation, name: "deathAnimation");
			attackAnimation = s.SerializeObject<StringID>(attackAnimation, name: "attackAnimation");
			deathBhv = s.SerializeObject<StringID>(deathBhv, name: "deathBhv");
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

