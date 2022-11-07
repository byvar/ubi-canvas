namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PadCursorComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DAE1851;
	}
}

