using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTActionOnComponentStateSetFact_Template : BTAction_Template {
		public StringID fact;
		public uint ComponentList;
		public uint StateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(ComponentList), "Invalid");
					SerializeFieldAsChoiceList(s, nameof(StateList)); // No empty for this
				} else {
					ComponentList = s.Serialize<uint>(ComponentList, name: "ComponentList");
					StateList = s.Serialize<uint>(StateList, name: "StateList");
				}
			} else {
				fact = s.SerializeObject<StringID>(fact, name: "fact");
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(ComponentList), "Invalid");
					SerializeFieldAsChoiceList(s, nameof(StateList)); // No empty for this
				} else {
					ComponentList = s.Serialize<uint>(ComponentList, name: "ComponentList");
					StateList = s.Serialize<uint>(StateList, name: "StateList");
				}
			}
		}
		public override uint? ClassCRC => 0x8D9BD77F;
	}
}

