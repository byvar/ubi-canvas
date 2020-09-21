using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion | GameFlags.RLVersion)]
	public partial class StaticMeshElement : CSerializable {
		public Vec3d pos;
		public Color color;
		public bool animated;
		public ObjectPath frisePath;
		public CArrayP<ushort> staticIndexList;
		public CListO<VertexPNC3T> staticVertexList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			color = s.SerializeObject<Color>(color, name: "color");
			animated = s.Serialize<bool>(animated, name: "animated");
			frisePath = s.SerializeObject<ObjectPath>(frisePath, name: "frisePath");
			staticIndexList = s.SerializeObject<CArrayP<ushort>>(staticIndexList, name: "staticIndexList");
			staticVertexList = s.SerializeObject<CListO<VertexPNC3T>>(staticVertexList, name: "staticVertexList");
		}
	}
}

