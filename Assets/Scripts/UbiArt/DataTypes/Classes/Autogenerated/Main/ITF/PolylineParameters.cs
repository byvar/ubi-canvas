namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class PolylineParameters : CSerializable {
		public float speedLoss;
		public float weightMultiplier = 1f;
		public float landSpeedMultiplier = 1f;
		public float hitForceMultiplier = 5f;
		public float impulseMultiplier = 1f;
		public float windMultiplier = 1f;
		public Path gameMaterial;
		public bool environment = true;
		public bool usePhantom;
		public bool useMovingPolyline;
		public StringID regionType;
		public bool forceNoBlockHit;
		public CListO<StringID> polylines;
		public CListO<StringID> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speedLoss = s.Serialize<float>(speedLoss, name: "speedLoss");
			weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
			landSpeedMultiplier = s.Serialize<float>(landSpeedMultiplier, name: "landSpeedMultiplier");
			hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
			impulseMultiplier = s.Serialize<float>(impulseMultiplier, name: "impulseMultiplier");
			windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			environment = s.Serialize<bool>(environment, name: "environment");
			usePhantom = s.Serialize<bool>(usePhantom, name: "usePhantom");
			useMovingPolyline = s.Serialize<bool>(useMovingPolyline, name: "useMovingPolyline");
			regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
			forceNoBlockHit = s.Serialize<bool>(forceNoBlockHit, name: "forceNoBlockHit");
			polylines = s.SerializeObject<CListO<StringID>>(polylines, name: "polylines");
			points = s.SerializeObject<CListO<StringID>>(points, name: "points");
		}
	}
}

