namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventGroupAction : Event {
		public uint groupIndex;
		public StringID groupAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				groupIndex = s.Serialize<uint>(groupIndex, name: "groupIndex");
				groupAction = s.SerializeObject<StringID>(groupAction, name: "groupAction");
			} else {
			}
		}
		public override uint? ClassCRC => 0xD61DD8DC;
	}
}

