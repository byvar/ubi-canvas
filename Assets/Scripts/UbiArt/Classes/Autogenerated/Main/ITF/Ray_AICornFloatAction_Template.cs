using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AICornFloatAction_Template : AIAction_Template {
		[Serialize("floatHeightMin"       )] public float floatHeightMin;
		[Serialize("floatIntervalMin"     )] public float floatIntervalMin;
		[Serialize("floatIntervalMax"     )] public float floatIntervalMax;
		[Serialize("floatHeightMax"       )] public float floatHeightMax;
		[Serialize("springConstant"       )] public float springConstant;
		[Serialize("frictionConstant"     )] public float frictionConstant;
		[Serialize("weightThreshold"      )] public float weightThreshold;
		[Serialize("lowerSpringConstant"  )] public float lowerSpringConstant;
		[Serialize("lowerFrictionConstant")] public float lowerFrictionConstant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(floatHeightMin));
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
		public override uint? ClassCRC => 0xD988E29B;
	}
}

