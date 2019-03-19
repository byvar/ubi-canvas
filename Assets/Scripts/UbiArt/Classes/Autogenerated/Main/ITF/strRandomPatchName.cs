using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class strRandomPatchName : CSerializable {
		[Serialize("PatchName")] public StringID PatchName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PatchName));
		}
	}
}

