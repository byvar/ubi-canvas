namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimPartitionEvent : AnimMarkerEvent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC301A504;
	}
}

