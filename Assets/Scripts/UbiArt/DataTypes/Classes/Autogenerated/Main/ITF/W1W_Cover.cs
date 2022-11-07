namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Cover : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB174CD99;
	}
}

