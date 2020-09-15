using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Mesh3dData : CSerializable {
		[Serialize("uvMin"   )] public Vec2d uvMin;
		[Serialize("uvMax"   )] public Vec2d uvMax;
		[Serialize("meshList")] public CList<Mesh3dDataElement> meshList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uvMin));
			SerializeField(s, nameof(uvMax));
			SerializeField(s, nameof(meshList));
		}
	}
}

