namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventRichPresence : Event {
		public uint presenceIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			presenceIndex = s.Serialize<uint>(presenceIndex, name: "presenceIndex");
		}
		public override uint? ClassCRC => 0x3C834FC3;
	}
}

