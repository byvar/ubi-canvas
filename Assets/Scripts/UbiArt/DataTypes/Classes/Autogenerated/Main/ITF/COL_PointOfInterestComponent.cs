namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointOfInterestComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDF913883;
	}
}

