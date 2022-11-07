namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgress : CSerializable {
		public StringID Name;
		public CListO<GameProgress> GameProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Name = s.SerializeObject<StringID>(Name, name: "Name");
			GameProgressList = s.SerializeObject<CListO<GameProgress>>(GameProgressList, name: "GameProgressList");
		}
	}
}

