using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DragonTriggerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x78CD1119;
	}
}

