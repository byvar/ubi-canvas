namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_MusicalModeDefinition : CSerializable {
		public Path MapPath;
		public Path BackgroundPath;
		public Path ScoreRecapPath;
		public uint MaxLums;
		public LocalisationId MusicLocId;
		public StringID medalAnm;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MapPath = s.SerializeObject<Path>(MapPath, name: "MapPath");
			BackgroundPath = s.SerializeObject<Path>(BackgroundPath, name: "BackgroundPath");
			ScoreRecapPath = s.SerializeObject<Path>(ScoreRecapPath, name: "ScoreRecapPath");
			MaxLums = s.Serialize<uint>(MaxLums, name: "MaxLums");
			MusicLocId = s.SerializeObject<LocalisationId>(MusicLocId, name: "MusicLocId");
			medalAnm = s.SerializeObject<StringID>(medalAnm, name: "medalAnm");
		}
		public override uint? ClassCRC => 0xB1911E05;
	}
}

