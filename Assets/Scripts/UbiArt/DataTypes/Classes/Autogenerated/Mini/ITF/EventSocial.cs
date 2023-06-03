namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventSocial : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x505CBC57;
	}
}

