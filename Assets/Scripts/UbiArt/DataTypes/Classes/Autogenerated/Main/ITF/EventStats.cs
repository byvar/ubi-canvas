namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventStats : Event {
		public CMap<string, string> Data;
		public string Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Data = s.SerializeObject<CMap<string, string>>(Data, name: "Data");
			Name = s.Serialize<string>(Name, name: "Name");
		}
		public override uint? ClassCRC => 0x3B5D3CF1;
	}
}

