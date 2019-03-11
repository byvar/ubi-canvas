using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIDeathBehavior : AIBehavior {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBE9A6D49;
	}
}

