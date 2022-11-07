namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class LinkComponent_Template : ActorComponent_Template {
		public bool transferEventsToChildren;
		public Color debugColor;
		public Color debugColorSelected;
		public int debugChildIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR) {
			} else if (s.Settings.game == Settings.Game.RO) {
				if (!s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags_xC0)) {
					debugColor = s.SerializeObject<Color>(debugColor, name: "debugColor");
					debugColorSelected = s.SerializeObject<Color>(debugColorSelected, name: "debugColorSelected");
					debugChildIndex = s.Serialize<int>(debugChildIndex, name: "debugChildIndex");
				}
			} else {
				transferEventsToChildren = s.Serialize<bool>(transferEventsToChildren, name: "transferEventsToChildren");
			}
		}
		public override uint? ClassCRC => 0x642599B5;
	}
}

