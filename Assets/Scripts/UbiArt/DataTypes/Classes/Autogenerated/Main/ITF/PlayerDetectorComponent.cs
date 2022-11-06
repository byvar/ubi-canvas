using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayerDetectorComponent : ShapeDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x28C01093;
	}
}

