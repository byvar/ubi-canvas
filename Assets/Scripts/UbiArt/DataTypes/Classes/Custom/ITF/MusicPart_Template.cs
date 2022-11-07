namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicPart_Template : CSerializable {
		public StringID name;
		public Path path;
		public uint nbMeasures;
		public uint beatsPerBar;
		public int prefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			path = s.SerializeObject<Path>(path, name: "path");
			nbMeasures = s.Serialize<uint>(nbMeasures, name: "nbMeasures");
			beatsPerBar = s.Serialize<uint>(beatsPerBar, name: "beatsPerBar");
			prefetch = s.Serialize<int>(prefetch, name: "prefetch");
		}
	}
}
