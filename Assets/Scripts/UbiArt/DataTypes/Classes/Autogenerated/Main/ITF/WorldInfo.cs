namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class WorldInfo : CSerializable {
		public BasicString BasicString__0;
		public CListO<LevelInfo> CList_LevelInfo__1;
		public CListO<BasicString> CList_BasicString__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BasicString__0 = s.SerializeObject<BasicString>(BasicString__0, name: "BasicString__0");
			CList_LevelInfo__1 = s.SerializeObject<CListO<LevelInfo>>(CList_LevelInfo__1, name: "CList<LevelInfo>__1");
			CList_BasicString__2 = s.SerializeObject<CListO<BasicString>>(CList_BasicString__2, name: "CList<BasicString>__2");
		}
	}
}

