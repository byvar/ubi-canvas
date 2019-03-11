using UnityEngine;

namespace UbiArt.ITF {
	public partial class HingePlatformComponent : PolylineComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEAABBA84;
	}
}

