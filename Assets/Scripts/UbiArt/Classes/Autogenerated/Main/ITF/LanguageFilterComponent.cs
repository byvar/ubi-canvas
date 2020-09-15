using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class LanguageFilterComponent : ActorComponent {
		public Enum_operator _operator;
		public CArray<uint> languages;
		public bool isDemo;
		public Enum_VH_0 Enum_VH_0__0;
		public CArray<uint> CArray_uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				CArray_uint__1 = s.SerializeObject<CArray<uint>>(CArray_uint__1, name: "CArray_uint__1");
			} else {
				_operator = s.Serialize<Enum_operator>(_operator, name: "_operator");
				languages = s.SerializeObject<CArray<uint>>(languages, name: "languages");
				languages = s.SerializeObject<CArray<uint>>(languages, name: "languages");
				isDemo = s.Serialize<bool>(isDemo, name: "isDemo");
			}
		}
		public enum Enum_operator {
			[Serialize("ITF_OPERATOR_IS"   )] ITF_OPERATOR_IS = 0,
			[Serialize("ITF_OPERATOR_ISNOT")] ITF_OPERATOR_ISNOT = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x86F2A466;
	}
}

