using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightOrbSetup : Event {
		[Serialize("type"    )] public Enum_type type;
		[Serialize("orbCount")] public float orbCount;
		[Serialize("picked"  )] public int picked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(orbCount));
			SerializeField(s, nameof(picked));
		}
		public enum Enum_type {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x519336F7;
	}
}

