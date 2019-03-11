using UnityEngine;

namespace UbiArt.ITF {
	public partial class SpeedInputProviderComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xED3EF786;
	}
}

