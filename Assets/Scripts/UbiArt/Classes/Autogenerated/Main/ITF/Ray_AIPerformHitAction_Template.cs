using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_AIPerformHitAction_Template : AIAction_Template {
		[Serialize("uint__0"      )] public uint uint__0;
		[Serialize("Enum_RJR_0__1")] public Enum_RJR_0 Enum_RJR_0__1;
		[Serialize("StringID__2"  )] public StringID StringID__2;
		[Serialize("int__3"       )] public int int__3;
		[Serialize("uint__4"      )] public uint uint__4;
		[Serialize("Enum_RFR_0__5")] public Enum_RFR_0 Enum_RFR_0__5;
		[Serialize("StringID__6"  )] public StringID StringID__6;
		[Serialize("int__7"       )] public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(Enum_RFR_0__5));
				SerializeField(s, nameof(StringID__6));
				SerializeField(s, nameof(int__7));
			} else {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(Enum_RJR_0__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(int__3));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x94259280;
	}
}

