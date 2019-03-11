using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ActorPlugTransfoController_Template : ActorPlugPlayableController_Template {
		[Serialize("autoUnplugDelay"  )] public float autoUnplugDelay;
		[Serialize("autoUnplugWarning")] public float autoUnplugWarning;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(autoUnplugDelay));
			SerializeField(s, nameof(autoUnplugWarning));
		}
		public override uint? ClassCRC => 0x9EEEA27C;
	}
}

