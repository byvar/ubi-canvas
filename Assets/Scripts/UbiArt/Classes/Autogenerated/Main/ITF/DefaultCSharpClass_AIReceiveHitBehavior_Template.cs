using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DefaultCSharpClass_AIReceiveHitBehavior_Template : AIReceiveHitBehavior_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x675DC3A8;
	}
}

