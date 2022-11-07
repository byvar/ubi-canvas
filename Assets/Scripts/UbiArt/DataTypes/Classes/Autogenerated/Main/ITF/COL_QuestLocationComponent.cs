namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_QuestLocationComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7EF8CFCB;
	}
}

