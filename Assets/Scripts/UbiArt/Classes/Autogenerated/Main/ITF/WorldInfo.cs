using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class WorldInfo : CSerializable {
		[Serialize("BasicString__0"       )] public BasicString BasicString__0;
		[Serialize("CList<LevelInfo>__1"  )] public CList<LevelInfo> CList_LevelInfo__1;
		[Serialize("CList<BasicString>__2")] public CList<BasicString> CList_BasicString__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BasicString__0));
			SerializeField(s, nameof(CList_LevelInfo__1));
			SerializeField(s, nameof(CList_BasicString__2));
		}
	}
}

