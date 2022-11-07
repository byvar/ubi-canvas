namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class World : BaseObject {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC5218963;
	}
}

