namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class BusMixCommand : SoundCommand {
		public StringID name;
		public int activate;
		public BusMix busParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			activate = s.Serialize<int>(activate, name: "activate");
			busParams = s.SerializeObject<BusMix>(busParams, name: "busParams");
		}
		public override uint? ClassCRC => 0xA61DB3DB;
	}
}

