using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsOverride : CSerializable {
		[Serialize("json"     )] public string json;
		[Serialize("condition")] public GameGlobalsComplexCondition condition;
		[Serialize("name"     )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(json));
			SerializeField(s, nameof(condition));
			SerializeField(s, nameof(name));
		}
	}
}

