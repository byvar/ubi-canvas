using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SinkingPlatformComponent_Template : CSerializable {
		[Serialize("weightStep"        )] public float weightStep;
		[Serialize("factor"            )] public float factor;
		[Serialize("stepMultiplier"    )] public float stepMultiplier;
		[Serialize("maxDistance"       )] public float maxDistance;
		[Serialize("restorationFactor" )] public float restorationFactor;
		[Serialize("waterInfluenceBone")] public StringID waterInfluenceBone;
		[Serialize("sinkFx"            )] public StringID sinkFx;
		[Serialize("floatFx"           )] public StringID floatFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(weightStep));
			SerializeField(s, nameof(factor));
			SerializeField(s, nameof(stepMultiplier));
			SerializeField(s, nameof(maxDistance));
			SerializeField(s, nameof(restorationFactor));
			SerializeField(s, nameof(waterInfluenceBone));
			SerializeField(s, nameof(sinkFx));
			SerializeField(s, nameof(floatFx));
		}
		public override uint? ClassCRC => 0x8526896A;
	}
}

