using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PushButtonComponent_Template : ActorComponent_Template {
		[Serialize("onOffDuration"       )] public float onOffDuration;
		[Serialize("delay"               )] public float delay;
		[Serialize("activateChildren"    )] public bool activateChildren;
		[Serialize("isProgressive"       )] public bool isProgressive;
		[Serialize("progressiveSpeed"    )] public float progressiveSpeed;
		[Serialize("progressiveHitLevels")] public CArray<uint> progressiveHitLevels;
		[Serialize("stayOn"              )] public bool stayOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onOffDuration));
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(activateChildren));
			SerializeField(s, nameof(isProgressive));
			SerializeField(s, nameof(progressiveSpeed));
			SerializeField(s, nameof(progressiveHitLevels));
			SerializeField(s, nameof(stayOn));
		}
		public override uint? ClassCRC => 0xC81F9119;
	}
}

