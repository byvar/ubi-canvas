using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ToadPlugAIController_Template : ActorPlugAIController_Template {
		[Serialize("jumpImpulse")] public float jumpImpulse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpImpulse));
		}
		public override uint? ClassCRC => 0xDD45C958;
	}
}

