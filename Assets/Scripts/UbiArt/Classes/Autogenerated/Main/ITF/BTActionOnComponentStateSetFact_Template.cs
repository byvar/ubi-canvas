using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTActionOnComponentStateSetFact_Template : BTAction_Template {
		[Serialize("fact"         )] public StringID fact;
		[Serialize("ComponentList")] public uint ComponentList;
		[Serialize("StateList"    )] public uint StateList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(fact));
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(ComponentList), "Invalid");
					SerializeFieldAsChoiceList(s, nameof(StateList)); // No empty for this
				} else {
					SerializeField(s, nameof(ComponentList));
					SerializeField(s, nameof(StateList));
				}
			} else {
				SerializeField(s, nameof(fact));
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(ComponentList), "Invalid");
					SerializeFieldAsChoiceList(s, nameof(StateList)); // No empty for this
				} else {
					SerializeField(s, nameof(ComponentList));
					SerializeField(s, nameof(StateList));
				}
			}
		}
		public override uint? ClassCRC => 0x8D9BD77F;
	}
}

