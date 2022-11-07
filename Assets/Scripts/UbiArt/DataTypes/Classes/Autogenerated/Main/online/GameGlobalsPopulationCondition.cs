namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GameGlobalsPopulationCondition : GameGlobalsCondition {
		public StringID kind;
		public StringID type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			kind = s.SerializeObject<StringID>(kind, name: "kind");
			type = s.SerializeObject<StringID>(type, name: "type");
		}
		public override uint? ClassCRC => 0xC5A0F7D6;
	}
}

