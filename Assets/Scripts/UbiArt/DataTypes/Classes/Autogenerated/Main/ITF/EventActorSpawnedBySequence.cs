namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class EventActorSpawnedBySequence : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDB07855A;
	}
}

