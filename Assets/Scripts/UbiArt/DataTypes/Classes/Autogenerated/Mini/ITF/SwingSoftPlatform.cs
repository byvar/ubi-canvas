namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class SwingSoftPlatform : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1F920B47;
	}
}

