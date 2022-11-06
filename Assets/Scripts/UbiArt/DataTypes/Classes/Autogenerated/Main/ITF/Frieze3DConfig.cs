using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Frieze3DConfig : CSerializable {
		public bool orient;
		public Path mesh3DFile;
		public Path mesh3DFile_Left;
		public Path mesh3DFile_Right;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			orient = s.Serialize<bool>(orient, name: "orient");
			mesh3DFile = s.SerializeObject<Path>(mesh3DFile, name: "mesh3DFile");
			mesh3DFile_Left = s.SerializeObject<Path>(mesh3DFile_Left, name: "mesh3DFile_Left");
			mesh3DFile_Right = s.SerializeObject<Path>(mesh3DFile_Right, name: "mesh3DFile_Right");
		}
	}
}

