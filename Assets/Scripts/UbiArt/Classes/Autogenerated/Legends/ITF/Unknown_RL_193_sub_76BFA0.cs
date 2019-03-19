using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_193_sub_76BFA0 : CSerializable {
		[Serialize("nodePaintingOffsetY")] public float nodePaintingOffsetY;
		[Serialize("frequency"          )] public Enum_frequency frequency;
		[Serialize("currentOffset"      )] public Vector3 currentOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodePaintingOffsetY));
			SerializeField(s, nameof(frequency));
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(currentOffset));
			}
		}
		public enum Enum_frequency {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0xFBA59E84;
	}
}

