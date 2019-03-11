using UnityEngine;

namespace UbiArt.ITF {
	public partial class LanguageFilterComponent : ActorComponent {
		[Serialize("operator" )] public Enum_operator _operator;
		[Serialize("languages")] public CArray<uint> languages;
		[Serialize("isDemo"   )] public bool isDemo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(_operator));
			SerializeField(s, nameof(languages));
			SerializeField(s, nameof(isDemo));
		}
		public enum Enum_operator {
			[Serialize("ITF_OPERATOR_IS"   )] ITF_OPERATOR_IS = 0,
			[Serialize("ITF_OPERATOR_ISNOT")] ITF_OPERATOR_ISNOT = 1,
		}
		public override uint? ClassCRC => 0x86F2A466;
	}
}

