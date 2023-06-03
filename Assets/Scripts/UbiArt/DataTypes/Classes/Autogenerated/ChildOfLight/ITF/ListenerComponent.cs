namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class ListenerComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2449D4A5;
	}
}

