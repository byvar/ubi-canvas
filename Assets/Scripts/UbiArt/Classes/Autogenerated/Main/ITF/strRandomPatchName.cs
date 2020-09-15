using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class strRandomPatchName : CSerializable {
		public StringID PatchName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PatchName = s.SerializeObject<StringID>(PatchName, name: "PatchName");
		}
	}
}

