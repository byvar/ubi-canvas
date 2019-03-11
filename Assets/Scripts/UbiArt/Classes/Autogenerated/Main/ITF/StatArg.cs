using UnityEngine;

namespace UbiArt.ITF {
	public partial class StatArg : CSerializable {
		[Serialize("name" )] public string name;
		[Serialize("value")] public StatValue value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(value));
		}
	}
}

