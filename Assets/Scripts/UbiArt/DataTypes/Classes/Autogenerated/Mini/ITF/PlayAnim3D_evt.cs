namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class PlayAnim3D_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6A5DC1A8;
	}
}

