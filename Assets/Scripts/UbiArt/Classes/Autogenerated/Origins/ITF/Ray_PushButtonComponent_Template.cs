using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PushButtonComponent_Template : CSerializable {
		[Serialize("onOffDuration"       )] public float onOffDuration;
		[Serialize("delay"               )] public float delay;
		[Serialize("activateChildren"    )] public bool activateChildren;
		[Serialize("triggerOnStick"      )] public bool triggerOnStick;
		[Serialize("triggerOnHit"        )] public bool triggerOnHit;
		[Serialize("isProgressive"       )] public bool isProgressive;
		[Serialize("progressiveSpeed"    )] public float progressiveSpeed;
		[Serialize("progressiveHitLevels")] public Placeholder progressiveHitLevels;
		[Serialize("stayOn"              )] public bool stayOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onOffDuration));
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(activateChildren));
			SerializeField(s, nameof(triggerOnStick));
			SerializeField(s, nameof(triggerOnHit));
			SerializeField(s, nameof(isProgressive));
			SerializeField(s, nameof(progressiveSpeed));
			SerializeField(s, nameof(progressiveHitLevels));
			SerializeField(s, nameof(stayOn));
		}
		public override uint? ClassCRC => 0x9308A6E7;
	}
}

