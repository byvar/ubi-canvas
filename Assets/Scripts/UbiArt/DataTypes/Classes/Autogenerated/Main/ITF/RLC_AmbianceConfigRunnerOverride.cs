namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfigRunnerOverride : RLC_AmbianceConfig {
		public Path MapPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MapPath = s.SerializeObject<Path>(MapPath, name: "MapPath");
		}
		public override uint? ClassCRC => 0xCE6FB512;
	}
}

