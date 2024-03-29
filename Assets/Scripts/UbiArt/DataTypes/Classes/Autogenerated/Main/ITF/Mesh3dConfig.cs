namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Mesh3dConfig : CSerializable {
		public float texureTileSize = 1f;
		public bool random = true;
		public CListO<Mesh3dData> mesh3dList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			texureTileSize = s.Serialize<float>(texureTileSize, name: "texureTileSize");
			random = s.Serialize<bool>(random, name: "random");
			mesh3dList = s.SerializeObject<CListO<Mesh3dData>>(mesh3dList, name: "mesh3dList");
		}
	}
}

