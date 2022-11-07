namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BasicPowerUpData : CSerializable {
		public bool enabled;
		public bool toAllPlayers;
		public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enabled = s.Serialize<bool>(enabled, name: "enabled");
			toAllPlayers = s.Serialize<bool>(toAllPlayers, name: "toAllPlayers");
			index = s.Serialize<uint>(index, name: "index");
		}
		public override uint? ClassCRC => 0xB22D2A8E;
	}
}

