using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class LanguageFilterComponent : ActorComponent {
		public Enum_operator _operator;
		public CArrayP<uint> languages;
		public bool isDemo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				_operator = s.Serialize<Enum_operator>(_operator, name: "operator");
				languages = s.SerializeObject<CArrayP<uint>>(languages, name: "languages");
			} else {
				_operator = s.Serialize<Enum_operator>(_operator, name: "operator");
				languages = s.SerializeObject<CArrayP<uint>>(languages, name: "languages");
				isDemo = s.Serialize<bool>(isDemo, name: "isDemo");
			}
		}
		public enum Enum_operator {
			[Serialize("ITF_OPERATOR_IS"   )] ITF_OPERATOR_IS = 0,
			[Serialize("ITF_OPERATOR_ISNOT")] ITF_OPERATOR_ISNOT = 1,
		}
		public override uint? ClassCRC => 0x86F2A466;
	}
}

