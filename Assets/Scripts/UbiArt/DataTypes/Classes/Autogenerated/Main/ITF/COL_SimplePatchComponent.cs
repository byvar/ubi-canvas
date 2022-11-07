namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SimplePatchComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4E298E6F;
	}
}

