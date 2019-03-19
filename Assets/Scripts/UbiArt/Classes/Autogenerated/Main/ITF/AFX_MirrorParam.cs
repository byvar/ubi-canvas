using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AFX_MirrorParam : CSerializable {
		[Serialize("use"    )] public bool use;
		[Serialize("offsetX")] public float offsetX;
		[Serialize("offsetY")] public float offsetY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(offsetX));
			SerializeField(s, nameof(offsetY));
		}
	}
}

