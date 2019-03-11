using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_426_sub_B88830 : CSerializable {
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public override uint? ClassCRC => 0x0C7AC209;
	}
}

