namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventGoingToStartScreen : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD5EC17E2;
	}
}

