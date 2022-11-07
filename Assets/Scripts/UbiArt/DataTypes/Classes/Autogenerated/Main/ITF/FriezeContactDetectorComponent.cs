namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class FriezeContactDetectorComponent : DetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2AA741CA;
	}
}

