namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventPlayerChangeTeam : Event {
		public uint asker;
		public uint changer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			asker = s.Serialize<uint>(asker, name: "asker");
			changer = s.Serialize<uint>(changer, name: "changer");
		}
		public override uint? ClassCRC => 0x2C0C74A3;
	}
}

