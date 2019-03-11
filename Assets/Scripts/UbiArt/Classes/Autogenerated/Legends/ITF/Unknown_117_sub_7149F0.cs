using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_117_sub_7149F0 : CSerializable {
		[Serialize("requireActivationTrigger")] public bool requireActivationTrigger;
		[Serialize("oneShotAnimation"        )] public bool oneShotAnimation;
		[Serialize("lumsToGive"              )] public uint lumsToGive;
		[Serialize("drcDetectionShapeRadius" )] public float drcDetectionShapeRadius;
		[Serialize("canReInit"               )] public bool canReInit;
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

