using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RockFishAIComponent_Template : CSerializable {
		public Placeholder attackDetectionShape;
		public float detectionRadius;
		public float minDetectTime;
		public float minIdleTime;
		public StringID sleepAnim;
		public StringID detectAnim;
		public StringID openAnim;
		public StringID closeAnim;
		public float openTime;
		public Placeholder points;
		public StringID regionType;
		public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attackDetectionShape = s.SerializeObject<Placeholder>(attackDetectionShape, name: "attackDetectionShape");
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			minDetectTime = s.Serialize<float>(minDetectTime, name: "minDetectTime");
			minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
			sleepAnim = s.SerializeObject<StringID>(sleepAnim, name: "sleepAnim");
			detectAnim = s.SerializeObject<StringID>(detectAnim, name: "detectAnim");
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			closeAnim = s.SerializeObject<StringID>(closeAnim, name: "closeAnim");
			openTime = s.Serialize<float>(openTime, name: "openTime");
			points = s.SerializeObject<Placeholder>(points, name: "points");
			regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
		}
		public override uint? ClassCRC => 0x656104B1;
	}
}

