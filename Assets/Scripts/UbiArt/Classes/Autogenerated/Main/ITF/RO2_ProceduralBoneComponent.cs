using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ProceduralBoneComponent : ProceduralBoneComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x952845B8;
	}
}

