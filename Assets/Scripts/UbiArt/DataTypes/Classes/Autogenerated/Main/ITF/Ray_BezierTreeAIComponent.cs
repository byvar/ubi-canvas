namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BezierTreeAIComponent : GraphicComponent {
		public int startActivated;
		public float branchSpeed;
		public Enum_RJR_0 polylineMode;
		public int flipTexture;
		public CListO<Ray_BezierTreeAIComponent.Branch> branches;
		public int int__0;
		public float float__1;
		public Enum_RFR_0 Enum_RFR_0__2;
		public int int__3;
		public CListO<Ray_BezierTreeAIComponent.Branch> CList_Ray_BezierTreeAIComponent_Branch__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					int__0 = s.Serialize<int>(int__0, name: "int__0");
					float__1 = s.Serialize<float>(float__1, name: "float__1");
					Enum_RFR_0__2 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__2, name: "Enum_RFR_0__2");
					int__3 = s.Serialize<int>(int__3, name: "int__3");
					CList_Ray_BezierTreeAIComponent_Branch__4 = s.SerializeObject<CListO<Ray_BezierTreeAIComponent.Branch>>(CList_Ray_BezierTreeAIComponent_Branch__4, name: "CList<Ray_BezierTreeAIComponent.Branch>__4");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					startActivated = s.Serialize<int>(startActivated, name: "startActivated");
					branchSpeed = s.Serialize<float>(branchSpeed, name: "branchSpeed");
					polylineMode = s.Serialize<Enum_RJR_0>(polylineMode, name: "polylineMode");
					flipTexture = s.Serialize<int>(flipTexture, name: "flipTexture");
					branches = s.SerializeObject<CListO<Ray_BezierTreeAIComponent.Branch>>(branches, name: "branches");
				}
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Node : CSerializable {
			public Vec3d Vector3__0;
			public float float__1;
			public float float__2;
			public float float__3;
			public StringID StringID__4;
			public float float__5;
			public StringID StringID__6;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Vector3__0 = s.SerializeObject<Vec3d>(Vector3__0, name: "Vector3__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				StringID__6 = s.SerializeObject<StringID>(StringID__6, name: "StringID__6");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class Branch : CSerializable {
			public CArrayO<Ray_BezierTreeAIComponent.Node> CArray_Ray_BezierTreeAIComponent_Node__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				CArray_Ray_BezierTreeAIComponent_Node__0 = s.SerializeObject<CArrayO<Ray_BezierTreeAIComponent.Node>>(CArray_Ray_BezierTreeAIComponent_Node__0, name: "CArray<Ray_BezierTreeAIComponent.Node>__0");
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x3AFFD116;
	}
}

