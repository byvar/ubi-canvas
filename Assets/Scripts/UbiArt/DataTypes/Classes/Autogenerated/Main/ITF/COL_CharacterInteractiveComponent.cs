namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterInteractiveComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5BC4E7A3;
	}
}

