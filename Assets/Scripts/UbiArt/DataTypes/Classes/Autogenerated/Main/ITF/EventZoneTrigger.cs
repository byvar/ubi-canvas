namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventZoneTrigger : EventTrigger {
		public StringID zoneID;
		public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			zoneID = s.SerializeObject<StringID>(zoneID, name: "zoneID");
			radius = s.Serialize<float>(radius, name: "radius");
		}
		public override uint? ClassCRC => 0x0A53E648;
	}
}

