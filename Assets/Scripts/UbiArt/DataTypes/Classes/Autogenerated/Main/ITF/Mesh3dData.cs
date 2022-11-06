using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Mesh3dData : CSerializable {
		public Vec2d uvMin;
		public Vec2d uvMax;
		public CListO<Mesh3dDataElement> meshList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uvMin = s.SerializeObject<Vec2d>(uvMin, name: "uvMin");
			uvMax = s.SerializeObject<Vec2d>(uvMax, name: "uvMax");
			meshList = s.SerializeObject<CListO<Mesh3dDataElement>>(meshList, name: "meshList");
		}
	}
}

