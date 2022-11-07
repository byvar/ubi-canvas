namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class Event : CSerializable {
		public ObjectRef sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR
				|| s.Settings.game == Settings.Game.RO
				|| s.Settings.game == Settings.Game.RFR
				|| s.Settings.game == Settings.Game.RL
				|| s.Settings.game == Settings.Game.COL) {
				sender = (ObjectRef)s.Serialize<uint>((uint)sender, name: "sender");
			} else if(s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					sender = s.SerializeObject<ObjectRef>(sender, name: "sender");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags18 | SerializeFlags.Flags19)) { // 0x0C0000 :thinking:
					sender = s.SerializeObject<ObjectRef>(sender, name: "sender");
				}
			}
		}
		public override uint? ClassCRC => 0x2E0A36E9;
	}
}

