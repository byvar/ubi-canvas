namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventLockCameraRegister : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF87AB034;
	}
}

