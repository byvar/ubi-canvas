namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WorldMapMenu_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA473863F;
	}
}

