using UnityEngine;

namespace UbiArt.ITF {
	public partial class Frieze3DConfig : CSerializable {
		[Serialize("orient"          )] public bool orient;
		[Serialize("mesh3DFile"      )] public Path mesh3DFile;
		[Serialize("mesh3DFile_Left" )] public Path mesh3DFile_Left;
		[Serialize("mesh3DFile_Right")] public Path mesh3DFile_Right;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(orient));
			SerializeField(s, nameof(mesh3DFile));
			SerializeField(s, nameof(mesh3DFile_Left));
			SerializeField(s, nameof(mesh3DFile_Right));
		}
	}
}

