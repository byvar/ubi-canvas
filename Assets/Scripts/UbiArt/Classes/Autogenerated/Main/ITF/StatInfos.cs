using UnityEngine;

namespace UbiArt.ITF {
	public partial class StatInfos : CSerializable {
		[Serialize("id"                  )] public StringID id;
		[Serialize("color"               )] public Color color;
		[Serialize("statName"            )] public SmartLocId statName;
		[Serialize("name"                )] public SmartLocId name;
		[Serialize("leaderboardTitle"    )] public SmartLocId leaderboardTitle;
		[Serialize("leaderboardTitleIcon")] public StringID leaderboardTitleIcon;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(statName));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(leaderboardTitle));
			SerializeField(s, nameof(leaderboardTitleIcon));
		}
	}
}

