namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class RotatingPolylineComponent : PolylineComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFB5EA5D5;
	}
}

