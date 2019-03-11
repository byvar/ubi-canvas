using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIDestroyAction : AIAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x363A1459;
	}
}

