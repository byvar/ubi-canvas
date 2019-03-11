using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderParamComponent : ActorComponent {
		[Serialize("ClearColor"        )] public SubRenderParam_ClearColor ClearColor;
		[Serialize("Lighting"          )] public SubRenderParam_Lighting Lighting;
		[Serialize("Miscellaneous"     )] public SubRenderParam_Misc Miscellaneous;
		[Serialize("Mask"              )] public SubRenderParam_Mask Mask;
		[Serialize("ColorRamp"         )] public SubRenderParam_ColorRamp ColorRamp;
		[Serialize("Priority"          )] public uint Priority;
		[Serialize("ViewportVisibility")] public uint ViewportVisibility;
		[Serialize("AlwaysActive"      )] public bool AlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ClearColor));
			SerializeField(s, nameof(Lighting));
			SerializeField(s, nameof(Miscellaneous));
			SerializeField(s, nameof(Mask));
			SerializeField(s, nameof(ColorRamp));
			SerializeField(s, nameof(Priority));
			SerializeField(s, nameof(ViewportVisibility));
			SerializeField(s, nameof(AlwaysActive));
		}
		public override uint? ClassCRC => 0x61E83173;
	}
}

