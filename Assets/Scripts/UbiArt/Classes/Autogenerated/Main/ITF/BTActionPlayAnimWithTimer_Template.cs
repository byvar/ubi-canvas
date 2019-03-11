using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionPlayAnimWithTimer_Template : BTActionPlayAnim_Template {
		[Serialize("minTime")] public float minTime;
		[Serialize("maxTime")] public float maxTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minTime));
			SerializeField(s, nameof(maxTime));
		}
		public override uint? ClassCRC => 0x25262D02;
	}
}

