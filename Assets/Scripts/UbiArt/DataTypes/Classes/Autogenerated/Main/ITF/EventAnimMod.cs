namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventAnimMod : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x79BC6D2F;
	}
}

