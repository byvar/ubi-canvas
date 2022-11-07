namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DeathDetectorComponent : DetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFD261A9C;
	}
}

