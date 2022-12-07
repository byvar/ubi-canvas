namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_FlexMeshBranchComponent : RO2_BezierBranchComponent {
		public CListO<RO2_FlexMeshBranchComponent.FlexMesh> meshes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			meshes = s.SerializeObject<CListO<RO2_FlexMeshBranchComponent.FlexMesh>>(meshes, name: "meshes");
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class FlexMesh : CSerializable {
			public StringID flexId;
			public float distance;
			public float offset;
			public float length = 1f;
			public float width = 1f;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				flexId = s.SerializeObject<StringID>(flexId, name: "flexId");
				distance = s.Serialize<float>(distance, name: "distance");
				offset = s.Serialize<float>(offset, name: "offset");
				length = s.Serialize<float>(length, name: "length");
				width = s.Serialize<float>(width, name: "width");
			}
		}
		public override uint? ClassCRC => 0xDB9C4247;
	}
}

