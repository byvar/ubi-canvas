namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RockFishAIComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> attackDetectionShape;
		public float detectionRadius;
		public float minDetectTime;
		public float minIdleTime;
		public StringID sleepAnim;
		public StringID detectAnim;
		public StringID openAnim;
		public StringID closeAnim;
		public StringID grabbedAnim;
		public float openTime;
		public CArrayO<Vec2d> points;
		public StringID regionType;
		public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				attackDetectionShape = s.SerializeObject<Generic<PhysShape>>(attackDetectionShape, name: "attackDetectionShape");
				detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
				minDetectTime = s.Serialize<float>(minDetectTime, name: "minDetectTime");
				minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
				sleepAnim = s.SerializeObject<StringID>(sleepAnim, name: "sleepAnim");
				detectAnim = s.SerializeObject<StringID>(detectAnim, name: "detectAnim");
				openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
				closeAnim = s.SerializeObject<StringID>(closeAnim, name: "closeAnim");
				grabbedAnim = s.SerializeObject<StringID>(grabbedAnim, name: "grabbedAnim");
				openTime = s.Serialize<float>(openTime, name: "openTime");
				points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
				regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			} else {
				attackDetectionShape = s.SerializeObject<Generic<PhysShape>>(attackDetectionShape, name: "attackDetectionShape");
				detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
				minDetectTime = s.Serialize<float>(minDetectTime, name: "minDetectTime");
				minIdleTime = s.Serialize<float>(minIdleTime, name: "minIdleTime");
				sleepAnim = s.SerializeObject<StringID>(sleepAnim, name: "sleepAnim");
				detectAnim = s.SerializeObject<StringID>(detectAnim, name: "detectAnim");
				openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
				closeAnim = s.SerializeObject<StringID>(closeAnim, name: "closeAnim");
				grabbedAnim = s.SerializeObject<StringID>(grabbedAnim, name: "grabbedAnim");
				openTime = s.Serialize<float>(openTime, name: "openTime");
				points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
				points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
				regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			}
		}
		public override uint? ClassCRC => 0x28BADD8F;
	}
}

