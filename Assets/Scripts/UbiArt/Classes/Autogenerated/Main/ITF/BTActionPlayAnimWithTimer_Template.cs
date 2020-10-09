using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BTActionPlayAnimWithTimer_Template : BTActionPlayAnim_Template {
		public float minTime;
		public float maxTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minTime = s.Serialize<float>(minTime, name: "minTime");
			maxTime = s.Serialize<float>(maxTime, name: "maxTime");
		}
		public override uint? ClassCRC => 0x25262D02;
	}
}

