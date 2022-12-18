namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeWaypointComponent : RO2_HomeComponent {
		public StringID type;
		public int value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.SerializeObject<StringID>(type, name: "type");
			value = s.Serialize<int>(value, name: "value");
		}
		public override uint? ClassCRC => 0x047CADF9;
	}
}

