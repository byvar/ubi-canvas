using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RM)]
	public partial class SubRenderParam_Misc : SubRenderParam {
		public GFX_VIEW_ZPASS ZPassOverride;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ZPassOverride = s.Serialize<GFX_VIEW_ZPASS>(ZPassOverride, name: "ZPassOverride");
		}
		public enum GFX_VIEW_ZPASS {
			[Serialize("GFX_VIEW_ZPASS_DEFAULT"        )] DEFAULT = 0,
			[Serialize("GFX_VIEW_ZPASS_FORCE_USE_ZPASS")] FORCE_USE_ZPASS = 1,
			[Serialize("GFX_VIEW_ZPASS_FORCE_NO_ZPASS" )] FORCE_NO_ZPASS = 2,
		}
		public override uint? ClassCRC => 0x1B6979E9;
	}
}

