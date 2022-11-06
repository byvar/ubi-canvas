using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class DeathDetectorComponent_Template : DetectorComponent_Template {
		public bool isAnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isAnd = s.Serialize<bool>(isAnd, name: "isAnd");
		}
		public override uint? ClassCRC => 0x40206760;
	}
}

