using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class BTNode_Template : CSerializable {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
		}
		public override uint? ClassCRC => 0x7E1E130A;
	}
}

