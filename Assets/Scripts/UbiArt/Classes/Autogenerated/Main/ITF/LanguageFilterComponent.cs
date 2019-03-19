using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class LanguageFilterComponent : ActorComponent {
		[Serialize("operator"       )] public Enum_operator _operator;
		[Serialize("languages"      )] public CArray<uint> languages;
		[Serialize("isDemo"         )] public bool isDemo;
		[Serialize("Enum_VH_0__0"   )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("CArray<uint>__1")] public CArray<uint> CArray_uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(CArray_uint__1));
			} else {
				SerializeField(s, nameof(_operator));
				SerializeField(s, nameof(languages));
				SerializeField(s, nameof(languages));
				SerializeField(s, nameof(isDemo));
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

