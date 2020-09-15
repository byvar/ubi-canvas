using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class SequenceTrackInfo_Template : CSerializable {
		public bool isEnable;
		public bool selected;
		public bool isGroup;
		public uint parentGroup;
		public string name;
		public bool fold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isEnable = s.Serialize<bool>(isEnable, name: "isEnable");
			selected = s.Serialize<bool>(selected, name: "selected");
			isGroup = s.Serialize<bool>(isGroup, name: "isGroup");
			parentGroup = s.Serialize<uint>(parentGroup, name: "parentGroup");
			name = s.Serialize<string>(name, name: "name");
			fold = s.Serialize<bool>(fold, name: "fold");
		}
	}
}

