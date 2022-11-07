namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class UIMenuPageSoundConfig : CSerializable {
		public StringID pageName;
		public CListO<UIMenuActionSound> actionSoundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pageName = s.SerializeObject<StringID>(pageName, name: "pageName");
			actionSoundList = s.SerializeObject<CListO<UIMenuActionSound>>(actionSoundList, name: "actionSoundList");
		}
	}
}

