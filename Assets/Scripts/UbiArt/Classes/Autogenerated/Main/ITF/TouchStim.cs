using UnityEngine;

namespace UbiArt.ITF {
	public partial class TouchStim : HitStim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC49A43AC;
	}
}

