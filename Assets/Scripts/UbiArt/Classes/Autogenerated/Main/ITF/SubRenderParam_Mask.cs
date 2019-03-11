using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubRenderParam_Mask : SubRenderParam {
		[Serialize("SilhouetteColor")] public Color SilhouetteColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SilhouetteColor));
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

