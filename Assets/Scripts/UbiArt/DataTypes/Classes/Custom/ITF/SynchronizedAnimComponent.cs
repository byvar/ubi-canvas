namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class SynchronizedAnimComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFC157114;
	}
}

