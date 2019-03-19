using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
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

