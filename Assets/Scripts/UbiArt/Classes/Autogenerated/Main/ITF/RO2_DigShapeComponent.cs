using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class RO2_DigShapeComponent : ActorComponent {
		[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("float__1"    )] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(float__1));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x062BFA66;
	}
}

