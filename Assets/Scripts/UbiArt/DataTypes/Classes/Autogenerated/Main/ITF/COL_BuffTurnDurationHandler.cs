namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BuffTurnDurationHandler : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3D8D2279;
	}
}

