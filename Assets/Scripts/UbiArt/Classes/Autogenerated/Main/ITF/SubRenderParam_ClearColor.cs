using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SubRenderParam_ClearColor : SubRenderParam {
		[Serialize("ClearColor"          )] public Color ClearColor;
		[Serialize("ClearFrontLightColor")] public Color ClearFrontLightColor;
		[Serialize("ClearBackLightColor" )] public Color ClearBackLightColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ClearColor));
			SerializeField(s, nameof(ClearFrontLightColor));
			SerializeField(s, nameof(ClearBackLightColor));
		}
		public override uint? ClassCRC => 0x769C7EEA;
	}
}

