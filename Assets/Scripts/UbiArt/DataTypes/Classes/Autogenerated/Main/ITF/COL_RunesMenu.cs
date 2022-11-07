namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RunesMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1A59F619;
	}
}

