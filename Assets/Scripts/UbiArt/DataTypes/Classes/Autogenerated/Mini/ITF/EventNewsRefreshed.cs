namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class EventNewsRefreshed : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8637AA9C;
	}
}

