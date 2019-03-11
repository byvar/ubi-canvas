using UnityEngine;

namespace UbiArt.ITF {
	public partial class AlwaysActiveActorComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC6FD064E;
	}
}

