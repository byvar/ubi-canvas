using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorSpawnComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAE141184;
	}
}

