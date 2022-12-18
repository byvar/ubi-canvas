namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class BusFilterCommand : SoundCommand {
		public CListO<StringID> buslist;
		public float frequency;
		public Enum_type type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buslist = s.SerializeObject<CListO<StringID>>(buslist, name: "buslist");
			frequency = s.Serialize<float>(frequency, name: "frequency");
			type = s.Serialize<Enum_type>(type, name: "type");
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xB65D7B19;
	}
}

