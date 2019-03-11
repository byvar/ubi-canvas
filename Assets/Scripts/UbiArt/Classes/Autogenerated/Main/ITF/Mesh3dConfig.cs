using UnityEngine;

namespace UbiArt.ITF {
	public partial class Mesh3dConfig : CSerializable {
		[Serialize("texureTileSize")] public float texureTileSize;
		[Serialize("random"        )] public bool random;
		[Serialize("mesh3dList"    )] public CList<Mesh3dData> mesh3dList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texureTileSize));
			SerializeField(s, nameof(random));
			SerializeField(s, nameof(mesh3dList));
		}
	}
}

