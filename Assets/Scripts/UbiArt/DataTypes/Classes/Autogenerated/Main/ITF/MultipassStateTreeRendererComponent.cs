namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MultipassStateTreeRendererComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBF78C57E;
	}
}

