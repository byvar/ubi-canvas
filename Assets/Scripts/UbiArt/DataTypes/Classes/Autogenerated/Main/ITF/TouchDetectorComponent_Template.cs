using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchDetectorComponent_Template : ShapeDetectorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6C9DDCBA;
	}
}

