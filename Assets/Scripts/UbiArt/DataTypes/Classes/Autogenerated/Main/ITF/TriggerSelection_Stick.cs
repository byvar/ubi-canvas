namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TriggerSelection_Stick : TriggerSelectionAbstract {
		public bool Self;
		public StringID TagName;
		public uint TagValue;
		public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			} else {
				Self = s.Serialize<bool>(Self, name: "Self");
				TagName = s.SerializeObject<StringID>(TagName, name: "TagName");
				TagValue = s.Serialize<uint>(TagValue, name: "TagValue");
			}
		}
		public override uint? ClassCRC => 0x3A0A6EFE;
	}
}

