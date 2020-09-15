using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Mesh3dConfig : CSerializable {
		public float texureTileSize;
		public bool random;
		public CList<Mesh3dData> mesh3dList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texureTileSize = s.Serialize<float>(texureTileSize, name: "texureTileSize");
			random = s.Serialize<bool>(random, name: "random");
			mesh3dList = s.SerializeObject<CList<Mesh3dData>>(mesh3dList, name: "mesh3dList");
		}
	}
}

