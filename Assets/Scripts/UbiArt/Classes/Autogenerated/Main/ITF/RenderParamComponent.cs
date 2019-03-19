using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RenderParamComponent : ActorComponent {
		[Serialize("ClearColor"                  )] public SubRenderParam_ClearColor ClearColor;
		[Serialize("Lighting"                    )] public SubRenderParam_Lighting Lighting;
		[Serialize("Miscellaneous"               )] public SubRenderParam_Misc Miscellaneous;
		[Serialize("Mask"                        )] public SubRenderParam_Mask Mask;
		[Serialize("ColorRamp"                   )] public SubRenderParam_ColorRamp ColorRamp;
		[Serialize("Priority"                    )] public uint Priority;
		[Serialize("ViewportVisibility"          )] public uint ViewportVisibility;
		[Serialize("AlwaysActive"                )] public bool AlwaysActive;
		[Serialize("SubRenderParam_ClearColor__0")] public SubRenderParam_ClearColor SubRenderParam_ClearColor__0;
		[Serialize("SubRenderParam_Lighting__1"  )] public SubRenderParam_Lighting SubRenderParam_Lighting__1;
		[Serialize("SubRenderParam_Misc__2"      )] public SubRenderParam_Misc SubRenderParam_Misc__2;
		[Serialize("SubRenderParam_Mask__3"      )] public SubRenderParam_Mask SubRenderParam_Mask__3;
		[Serialize("uint__4"                     )] public uint uint__4;
		[Serialize("uint__5"                     )] public uint uint__5;
		[Serialize("bool__6"                     )] public bool bool__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(SubRenderParam_ClearColor__0));
				SerializeField(s, nameof(SubRenderParam_Lighting__1));
				SerializeField(s, nameof(SubRenderParam_Misc__2));
				SerializeField(s, nameof(SubRenderParam_Mask__3));
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(uint__5));
				SerializeField(s, nameof(bool__6));
			} else {
				SerializeField(s, nameof(ClearColor));
				SerializeField(s, nameof(Lighting));
				SerializeField(s, nameof(Miscellaneous));
				SerializeField(s, nameof(Mask));
				SerializeField(s, nameof(ColorRamp));
				SerializeField(s, nameof(Priority));
				SerializeField(s, nameof(ViewportVisibility));
				SerializeField(s, nameof(AlwaysActive));
			}
		}
		public override uint? ClassCRC => 0x61E83173;
	}
}

