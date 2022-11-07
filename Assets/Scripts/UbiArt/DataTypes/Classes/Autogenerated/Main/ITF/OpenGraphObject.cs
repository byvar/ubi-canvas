namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class OpenGraphObject : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC4B94B1F;
	}
}

