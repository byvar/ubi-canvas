namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicTheme : CSerializable {
		[Serialize("theme")] public StringID theme;
		[Serialize("path" )] public CString path;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(theme));
			SerializeField(s, nameof(path));
		}
	}
}