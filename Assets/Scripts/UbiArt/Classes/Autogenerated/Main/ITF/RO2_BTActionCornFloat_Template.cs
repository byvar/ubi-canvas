using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionCornFloat_Template : BTAction_Template {
		[Serialize("anim"                 )] public StringID anim;
		[Serialize("floatIntervalMin"     )] public float floatIntervalMin;
		[Serialize("floatIntervalMax"     )] public float floatIntervalMax;
		[Serialize("floatHeightMin"       )] public float floatHeightMin;
		[Serialize("floatHeightMax"       )] public float floatHeightMax;
		[Serialize("springConstant"       )] public float springConstant;
		[Serialize("frictionConstant"     )] public float frictionConstant;
		[Serialize("weightThreshold"      )] public float weightThreshold;
		[Serialize("lowerSpringConstant"  )] public float lowerSpringConstant;
		[Serialize("lowerFrictionConstant")] public float lowerFrictionConstant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(floatIntervalMin));
			SerializeField(s, nameof(floatIntervalMax));
			SerializeField(s, nameof(floatHeightMin));
			SerializeField(s, nameof(floatHeightMax));
			SerializeField(s, nameof(springConstant));
			SerializeField(s, nameof(frictionConstant));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(lowerSpringConstant));
			SerializeField(s, nameof(lowerFrictionConstant));
		}
		public override uint? ClassCRC => 0x6734201F;
	}
}

