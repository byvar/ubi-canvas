using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsOverride : CSerializable {
		public string json;
		public GameGlobalsComplexCondition condition;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			json = s.Serialize<string>(json, name: "json");
			condition = s.SerializeObject<GameGlobalsComplexCondition>(condition, name: "condition");
			name = s.SerializeObject<StringID>(name, name: "name");
		}
	}
}

