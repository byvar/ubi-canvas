using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_TileParam : CSerializable {
		[Serialize("use"       )] public bool use;
		[Serialize("repetition")] public float repetition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(repetition));
		}
	}
}

