namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicTheme : CSerializable {
		public StringID theme;
		public CString path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			theme = s.SerializeObject<StringID>(theme, name: "theme");
			path = s.Serialize<CString>(path, name: "path");
		}
	}
}
