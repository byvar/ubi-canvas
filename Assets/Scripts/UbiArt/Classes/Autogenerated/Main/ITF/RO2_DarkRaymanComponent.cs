using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DarkRaymanComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE70FADD5;
	}
}

