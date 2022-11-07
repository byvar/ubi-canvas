namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class GridFluidDensityRequest : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB40FB953;
	}
}

