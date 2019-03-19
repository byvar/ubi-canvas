using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class SubRenderParam_Lighting : SubRenderParam {
		[Serialize("GlobalColor"     )] public Color GlobalColor;
		[Serialize("GlobalStaticFog" )] public Color GlobalStaticFog;
		[Serialize("GlobalFogOpacity")] public float GlobalFogOpacity;
		[Serialize("GlobalBrightness")] public float GlobalBrightness;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(GlobalColor));
			SerializeField(s, nameof(GlobalStaticFog));
			SerializeField(s, nameof(GlobalFogOpacity));
			SerializeField(s, nameof(GlobalBrightness));
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

