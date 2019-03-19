using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ArchiveMemory : CSerializable {
		[Serialize("AMData")] public ArchiveMemory AMData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AMData));
		}
	}
}

