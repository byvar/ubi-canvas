using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RL)]
	public partial class RedirectSymmetryPatch : CSerializable {
		[Serialize("mainPatch")] public StringID mainPatch;
		[Serialize("boneName")] public StringID boneName;
		[Serialize("symmetryPatch")] public StringID symmetryPatch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mainPatch));
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(symmetryPatch));
		}
	}
}