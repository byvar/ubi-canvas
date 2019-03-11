using UnityEngine;

namespace UbiArt.ITF {
	public partial class DeathTriggerComponent : TriggerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAE2266A7;
	}
}

