namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DrawCameraComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5F3EB1BD;
	}
}

