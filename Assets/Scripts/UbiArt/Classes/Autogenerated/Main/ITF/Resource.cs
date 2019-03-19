using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RO | GameFlags.RO | GameFlags.RO | GameFlags.RL | GameFlags.RL)]
	public partial class Resource : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3205E118;
	}
}

