using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ShooterStimComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4444332F;
	}
}

