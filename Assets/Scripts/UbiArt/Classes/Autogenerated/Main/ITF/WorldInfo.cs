using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class WorldInfo : CSerializable {
		public BasicString BasicString__0;
		public CList<LevelInfo> CList_LevelInfo__1;
		public CList<BasicString> CList_BasicString__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BasicString__0 = s.SerializeObject<BasicString>(BasicString__0, name: "BasicString__0");
			CList_LevelInfo__1 = s.SerializeObject<CList<LevelInfo>>(CList_LevelInfo__1, name: "CList_LevelInfo__1");
			CList_BasicString__2 = s.SerializeObject<CList<BasicString>>(CList_BasicString__2, name: "CList_BasicString__2");
		}
	}
}

