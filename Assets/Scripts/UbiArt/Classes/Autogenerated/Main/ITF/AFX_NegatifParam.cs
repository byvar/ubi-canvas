using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_NegatifParam : CSerializable {
		[Serialize("use")] public bool use;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
		}
	}
}

