using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionGrowLight_Template : BTAction_Template {
		[Serialize("animGrowLight"    )] public StringID animGrowLight;
		[Serialize("growLightDuration")] public float growLightDuration;
		[Serialize("useGrowLightTimer")] public bool useGrowLightTimer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animGrowLight));
			SerializeField(s, nameof(growLightDuration));
			SerializeField(s, nameof(useGrowLightTimer));
		}
		public override uint? ClassCRC => 0x8D78F8D1;
	}
}

