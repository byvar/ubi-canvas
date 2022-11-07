namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventOffset : Event {
		public int offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offset = s.Serialize<int>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0xA1FBB08B;
	}
}

