using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchSpringPlatformComponent_Template : RO2_TouchSpringPlatformBaseComponent_Template {
		[Serialize("playAnimOnHold")] public StringID playAnimOnHold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playAnimOnHold));
		}
		public override uint? ClassCRC => 0xC253AA58;
	}
}

