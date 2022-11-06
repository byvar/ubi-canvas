using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class SubRenderParam_ClearColor : SubRenderParam {
		public Color ClearColor = Color.Black;
		public Color ClearFrontLightColor = Color.Black;
		public Color ClearBackLightColor = Color.Black;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ClearColor = s.SerializeObject<Color>(ClearColor, name: "ClearColor");
			ClearFrontLightColor = s.SerializeObject<Color>(ClearFrontLightColor, name: "ClearFrontLightColor");
			ClearBackLightColor = s.SerializeObject<Color>(ClearBackLightColor, name: "ClearBackLightColor");
		}
		public override uint? ClassCRC => 0x769C7EEA;
	}
}

