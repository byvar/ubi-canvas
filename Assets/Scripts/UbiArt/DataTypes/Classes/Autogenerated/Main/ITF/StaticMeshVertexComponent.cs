namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class StaticMeshVertexComponent : GraphicComponent {
		public CListO<StaticMeshElement> staticMeshElements;
		public CArrayP<uint> sortedMeshElements;
		public GFXMaterialSerializable material;
		public AABB localAABB;
		public float mergeRange = 0.1f;
		public ObjectPath friseGroupPath;
		public int forceMatrixUpdate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				staticMeshElements = s.SerializeObject<CListO<StaticMeshElement>>(staticMeshElements, name: "staticMeshElements");
				sortedMeshElements = s.SerializeObject<CArrayP<uint>>(sortedMeshElements, name: "sortedMeshElements");
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				friseGroupPath = s.SerializeObject<ObjectPath>(friseGroupPath, name: "friseGroupPath");
				forceMatrixUpdate = s.Serialize<int>(forceMatrixUpdate, name: "forceMatrixUpdate");
			} else {
				staticMeshElements = s.SerializeObject<CListO<StaticMeshElement>>(staticMeshElements, name: "staticMeshElements");
				sortedMeshElements = s.SerializeObject<CArrayP<uint>>(sortedMeshElements, name: "sortedMeshElements");
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				friseGroupPath = s.SerializeObject<ObjectPath>(friseGroupPath, name: "friseGroupPath");
			}
		}
		public override uint? ClassCRC => 0x2A83720E;
	}
}

