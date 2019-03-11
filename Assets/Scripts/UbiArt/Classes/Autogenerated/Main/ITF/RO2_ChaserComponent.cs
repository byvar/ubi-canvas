using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ChaserComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5EDF1063;
	}
}

