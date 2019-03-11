using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionOnComponentStateSetFact_Template : BTAction_Template {
		[Serialize("fact"         )] public StringID fact;
		[Serialize("ComponentList")] public Enum_ComponentList ComponentList;
		[Serialize("StateList"    )] public Enum_StateList StateList;
		[Serialize("ComponentList")] public uint ComponentList;
		[Serialize("StateList"    )] public uint StateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
			if (s.HasFlags(SerializeFlags.Flags_x03)) {
				SerializeField(s, nameof(ComponentList));
				SerializeField(s, nameof(StateList));
				SerializeField(s, nameof(ComponentList));
			}
			SerializeField(s, nameof(StateList));
		}
		public enum Enum_ComponentList {
			[Serialize("Invalid")] Invalid = -1,
		}
		public enum Enum_StateList {
		}
		public override uint? ClassCRC => 0x8D9BD77F;
	}
}

