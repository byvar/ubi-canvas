using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LizardPlugPlayableController_Template : ActorPlugPlayableController_Template {
		[Serialize("speed")] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0x18481B19;
	}
}

