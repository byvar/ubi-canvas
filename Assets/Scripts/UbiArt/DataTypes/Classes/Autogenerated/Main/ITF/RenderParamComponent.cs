namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class RenderParamComponent : ActorComponent {
		public SubRenderParam_ClearColor ClearColor;
		public SubRenderParam_Lighting Lighting;
		public SubRenderParam_Misc Miscellaneous;
		public SubRenderParam_Mask Mask;
		public SubRenderParam_ColorRamp ColorRamp;
		public uint Priority;
		public uint ViewportVisibility;
		public bool AlwaysActive;
		public SubRenderParam_ClearColor SubRenderParam_ClearColor__0;
		public SubRenderParam_Lighting SubRenderParam_Lighting__1;
		public SubRenderParam_Misc SubRenderParam_Misc__2;
		public SubRenderParam_Mask SubRenderParam_Mask__3;
		public uint uint__4;
		public uint uint__5;
		public bool bool__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH) {
				SubRenderParam_ClearColor__0 = s.SerializeObject<SubRenderParam_ClearColor>(SubRenderParam_ClearColor__0, name: "SubRenderParam_ClearColor__0");
				SubRenderParam_Lighting__1 = s.SerializeObject<SubRenderParam_Lighting>(SubRenderParam_Lighting__1, name: "SubRenderParam_Lighting__1");
				SubRenderParam_Misc__2 = s.SerializeObject<SubRenderParam_Misc>(SubRenderParam_Misc__2, name: "SubRenderParam_Misc__2");
				SubRenderParam_Mask__3 = s.SerializeObject<SubRenderParam_Mask>(SubRenderParam_Mask__3, name: "SubRenderParam_Mask__3");
				uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
				uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
			} else {
				ClearColor = s.SerializeObject<SubRenderParam_ClearColor>(ClearColor, name: "ClearColor");
				Lighting = s.SerializeObject<SubRenderParam_Lighting>(Lighting, name: "Lighting");
				Miscellaneous = s.SerializeObject<SubRenderParam_Misc>(Miscellaneous, name: "Miscellaneous");
				Mask = s.SerializeObject<SubRenderParam_Mask>(Mask, name: "Mask");
				ColorRamp = s.SerializeObject<SubRenderParam_ColorRamp>(ColorRamp, name: "ColorRamp");
				Priority = s.Serialize<uint>(Priority, name: "Priority");
				ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
				AlwaysActive = s.Serialize<bool>(AlwaysActive, name: "AlwaysActive");
			}
		}
		public override uint? ClassCRC => 0x61E83173;
	}
}

