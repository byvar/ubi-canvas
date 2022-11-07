namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventChildActorDestroyed : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6C6AEB99;
	}
}

