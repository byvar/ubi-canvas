using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTActionOnComponentStateSetFact_Template : BTAction_Template {
		[Serialize("fact"         )] public StringID fact;
		[Serialize("ComponentList")] public Enum_ComponentList ComponentList;
		[Serialize("StateList"    )] public Enum_StateList StateList;
		[Serialize("ComponentList")] public uint ComponentList;
		[Serialize("StateList"    )] public uint StateList;
		[Serialize("StringID__0"  )] public StringID StringID__0;
		[Serialize("Enum_VH_0__1" )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("Enum_VH_1__2" )] public Enum_VH_1 Enum_VH_1__2;
		[Serialize("uint__3"      )] public uint uint__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(Enum_VH_0__1));
					SerializeField(s, nameof(Enum_VH_1__2));
					SerializeField(s, nameof(uint__3));
				}
			} else {
				SerializeField(s, nameof(fact));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(ComponentList));
					SerializeField(s, nameof(StateList));
					SerializeField(s, nameof(ComponentList));
				}
				SerializeField(s, nameof(ComponentList));
				SerializeField(s, nameof(StateList));
			}
		}
		public enum Enum_ComponentList {
			[Serialize("Invalid")] Invalid = -1,
		}
		public enum Enum_StateList {
		}
		public enum Enum_VH_0 {
			[Serialize("Invalid")] Invalid = -1,
		}
		public enum Enum_VH_1 {
		}
		public override uint? ClassCRC => 0x8D9BD77F;
	}
}

