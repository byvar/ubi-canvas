using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class StaticMeshVertexComponent : GraphicComponent {
		public CList<StaticMeshElement> staticMeshElements;
		public CArray<uint> sortedMeshElements;
		public GFXMaterialSerializable material;
		public AABB localAABB;
		public float mergeRange;
		public ObjectPath friseGroupPath;
		public int forceMatrixUpdate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				staticMeshElements = s.SerializeObject<CList<StaticMeshElement>>(staticMeshElements, name: "staticMeshElements");
				sortedMeshElements = s.SerializeObject<CArray<uint>>(sortedMeshElements, name: "sortedMeshElements");
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				friseGroupPath = s.SerializeObject<ObjectPath>(friseGroupPath, name: "friseGroupPath");
				forceMatrixUpdate = s.Serialize<int>(forceMatrixUpdate, name: "forceMatrixUpdate");
			} else {
				staticMeshElements = s.SerializeObject<CList<StaticMeshElement>>(staticMeshElements, name: "staticMeshElements");
				sortedMeshElements = s.SerializeObject<CArray<uint>>(sortedMeshElements, name: "sortedMeshElements");
				material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
				localAABB = s.SerializeObject<AABB>(localAABB, name: "localAABB");
				mergeRange = s.Serialize<float>(mergeRange, name: "mergeRange");
				friseGroupPath = s.SerializeObject<ObjectPath>(friseGroupPath, name: "friseGroupPath");
			}
		}
		public override uint? ClassCRC => 0x2A83720E;
	}
}

