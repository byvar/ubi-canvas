namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MultiTextureGraphicComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3F137CA9;
	}
}

