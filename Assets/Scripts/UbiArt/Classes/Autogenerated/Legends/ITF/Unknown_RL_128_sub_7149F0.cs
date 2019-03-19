using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_128_sub_7149F0 : CSerializable {
		[Serialize("requireActivationTrigger")] public int requireActivationTrigger;
		[Serialize("oneShotAnimation"        )] public int oneShotAnimation;
		[Serialize("lumsToGive"              )] public uint lumsToGive;
		[Serialize("drcDetectionShapeRadius" )] public float drcDetectionShapeRadius;
		[Serialize("canReInit"               )] public int canReInit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(requireActivationTrigger));
			SerializeField(s, nameof(oneShotAnimation));
			SerializeField(s, nameof(lumsToGive));
			SerializeField(s, nameof(drcDetectionShapeRadius));
			SerializeField(s, nameof(canReInit));
		}
		public override uint? ClassCRC => 0xA7E2FA94;
	}
}

