using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9EE709E0;
	}
}

