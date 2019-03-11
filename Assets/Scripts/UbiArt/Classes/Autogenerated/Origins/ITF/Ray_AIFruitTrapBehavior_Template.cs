using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIFruitTrapBehavior_Template : CSerializable {
		[Serialize("delay"          )] public float delay;
		[Serialize("weightThreshold")] public float weightThreshold;
		[Serialize("standAction"    )] public Placeholder standAction;
		[Serialize("fruitFallAction")] public Placeholder fruitFallAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(standAction));
			SerializeField(s, nameof(fruitFallAction));
		}
		public override uint? ClassCRC => 0xB4066175;
	}
}

