using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_38759_sub_A04790 : CSerializable {
		[Serialize("type")] public Enum_type type;
		[Serialize("duration")] public float duration;
		[Serialize("additionalSpeed")] public Vector2 additionalSpeed;
		[Serialize("notifyPlayerDelay")] public float notifyPlayerDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(additionalSpeed));
			SerializeField(s, nameof(notifyPlayerDelay));
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
	}
}