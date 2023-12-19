namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BezierTreeAIComponent : GraphicComponent {
		public int startActivated;
		public float branchSpeed;
		public PolylineMode polylineMode;
		public int flipTexture;
		public CListO<Ray_BezierTreeAIComponent.Branch> branches;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startActivated = s.Serialize<int>(startActivated, name: "startActivated");
				branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
				polylineMode = s.Serialize<PolylineMode>(polylineMode, name: "polylineMode");
				flipTexture = s.Serialize<int>(flipTexture, name: "flipTexture");
				branches = s.SerializeObject<CListO<Ray_BezierTreeAIComponent.Branch>>(branches, name: "branches");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Node : CSerializable {
			public Vec3d pos;
			public float angle;
			public float scale;
			public float bezierTension;
			public StringID tweenSet;
			public float tweenOffset;
			public StringID spawnableName;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				pos = s.SerializeObject<Vec3d>(pos, name: "pos");
				angle = s.Serialize<float>(angle, name: "angle");
				scale = s.Serialize<float>(scale, name: "scale");
				bezierTension = s.Serialize<float>(bezierTension, name: "bezierTension");
				tweenSet = s.SerializeObject<StringID>(tweenSet, name: "tweenSet");
				tweenOffset = s.Serialize<float>(tweenOffset, name: "tweenOffset");
				spawnableName = s.SerializeObject<StringID>(spawnableName, name: "spawnableName");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Branch : CSerializable {
			public CArrayO<Ray_BezierTreeAIComponent.Node> nodes;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				nodes = s.SerializeObject<CArrayO<Ray_BezierTreeAIComponent.Node>>(nodes, name: "nodes");
			}
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None")] None = 0,
			[Serialize("PolylineMode_Left")] Left = 1,
			[Serialize("PolylineMode_Right")] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x3AFFD116;
	}
}

