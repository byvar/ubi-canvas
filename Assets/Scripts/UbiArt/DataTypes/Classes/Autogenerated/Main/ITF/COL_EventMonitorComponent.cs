namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventMonitorComponent : Event {
		public uint numToMonitor;
		public Placeholder successEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numToMonitor = s.Serialize<uint>(numToMonitor, name: "numToMonitor");
			successEvent = s.SerializeObject<Placeholder>(successEvent, name: "successEvent");
		}
		public override uint? ClassCRC => 0xA821D824;
	}
}

