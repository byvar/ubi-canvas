namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShadowZonePlayerDetectorComponent : DetectorComponent {
		public bool detectInLight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectInLight = s.Serialize<bool>(detectInLight, name: "detectInLight", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x0607E596;
	}
}

