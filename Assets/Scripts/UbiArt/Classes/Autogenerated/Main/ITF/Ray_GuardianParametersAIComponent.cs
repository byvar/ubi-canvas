using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianParametersAIComponent : ActorComponent {
		[Serialize("uint__0"      )] public uint uint__0;
		[Serialize("float__1"     )] public float float__1;
		[Serialize("float__2"     )] public float float__2;
		[Serialize("Enum_RFR_0__3")] public Enum_RFR_0 Enum_RFR_0__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("int__5"       )] public int int__5;
		[Serialize("uint__6"      )] public uint uint__6;
		[Serialize("Enum_RFR_1__7")] public Enum_RFR_1 Enum_RFR_1__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(Enum_RFR_0__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(Enum_RFR_1__7));
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x855077BC;
	}
}

