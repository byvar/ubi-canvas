namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class AtlasAnimationComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0E4F9BE2;
	}
}

