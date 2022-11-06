using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class SubRenderParam_Mask : SubRenderParam {
		public Color SilhouetteColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SilhouetteColor = s.SerializeObject<Color>(SilhouetteColor, name: "SilhouetteColor");
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

