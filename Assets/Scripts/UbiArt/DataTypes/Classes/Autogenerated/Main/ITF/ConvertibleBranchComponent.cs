namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class ConvertibleBranchComponent : BezierBranchComponent {
		public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				seed = s.Serialize<uint>(seed, name: "seed");
			}
		}
		public override uint? ClassCRC => 0xAFC1D751;
	}
}

