namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class UIMenuActionSound : CSerializable {
		public StringID action;
		public StringID selection;
		public StringID sound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			action = s.SerializeObject<StringID>(action, name: "action");
			selection = s.SerializeObject<StringID>(selection, name: "selection");
			sound = s.SerializeObject<StringID>(sound, name: "sound");
		}
	}
}

