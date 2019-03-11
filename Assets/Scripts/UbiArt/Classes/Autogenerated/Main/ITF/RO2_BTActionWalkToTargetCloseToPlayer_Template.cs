using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionWalkToTargetCloseToPlayer_Template : BTActionWalkToTarget_Template {
		[Serialize("checkIntervals")] public float checkIntervals;
		[Serialize("rangeMin"      )] public float rangeMin;
		[Serialize("rangeMax"      )] public float rangeMax;
		[Serialize("maxSpeed"      )] public float maxSpeed;
		[Serialize("minSpeed"      )] public float minSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(checkIntervals));
			SerializeField(s, nameof(rangeMin));
			SerializeField(s, nameof(rangeMax));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(minSpeed));
		}
		public override uint? ClassCRC => 0xA5041CD8;
	}
}

