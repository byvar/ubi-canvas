namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class Event : CSerializable {
		public ObjectRef sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR
				|| s.Settings.Game == Game.RO
				|| s.Settings.Game == Game.RFR
				|| s.Settings.Game == Game.RL
				|| s.Settings.Game == Game.COL) {
				sender = (ObjectRef)s.Serialize<uint>((uint)sender, name: "sender");
			} else if(s.Settings.Game == Game.VH) {
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

