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

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH) {
				ClearColor = s.SerializeObject<SubRenderParam_ClearColor>(ClearColor, name: "ClearColor");
				Lighting = s.SerializeObject<SubRenderParam_Lighting>(Lighting, name: "Lighting");
				Miscellaneous = s.SerializeObject<SubRenderParam_Misc>(Miscellaneous, name: "Miscellaneous");
				Mask = s.SerializeObject<SubRenderParam_Mask>(Mask, name: "Mask");
				Priority = s.Serialize<uint>(Priority, name: "Priority");
				ViewportVisibility = s.Serialize<uint>(ViewportVisibility, name: "ViewportVisibility");
				AlwaysActive = s.Serialize<bool>(AlwaysActive, name: "AlwaysActive");
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

