namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class BasculePlatformComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC9652618;
	}
}

