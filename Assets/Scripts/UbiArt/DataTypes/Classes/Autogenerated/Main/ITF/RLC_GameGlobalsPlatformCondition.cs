namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsPlatformCondition : online.GameGlobalsCondition {
		public GGPlatform platform;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			platform = s.Serialize<GGPlatform>(platform, name: "platform");
		}
		public enum GGPlatform {
			[Serialize("GGPlatform_iOS"    )] iOS = 0,
			[Serialize("GGPlatform_Fruity" )] Fruity = 1,
			[Serialize("GGPlatform_Android")] Android = 2,
		}
		public override uint? ClassCRC => 0x4DC9F3B3;
	}
}

