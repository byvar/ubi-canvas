namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class PloufComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7B084E0C;
	}
}

