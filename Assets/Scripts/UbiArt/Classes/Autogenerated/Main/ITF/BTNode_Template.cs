using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class BTNode_Template : CSerializable {
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0x7E1E130A;
	}
}

