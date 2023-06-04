namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RM)]
	public partial class BasicStateImplement : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x577DBAD2;
	}
}

