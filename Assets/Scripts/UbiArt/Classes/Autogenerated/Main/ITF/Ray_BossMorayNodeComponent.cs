using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BossMorayNodeComponent : ActorComponent {
		[Serialize("float__0"     )] public float float__0;
		[Serialize("float__1"     )] public float float__1;
		[Serialize("int__2"       )] public int int__2;
		[Serialize("Enum_RFR_0__3")] public Enum_RFR_0 Enum_RFR_0__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(Enum_RFR_0__3));
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x2BBA735D;
	}
}

