using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BossPlantNodeComponent_Template : CSerializable {
		[Serialize("anim"        )] public StringID anim;
		[Serialize("animPlayRate")] public float animPlayRate;
		[Serialize("cycleVector" )] public Vector2 cycleVector;
		[Serialize("triggerEvent")] public Placeholder triggerEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animPlayRate));
			SerializeField(s, nameof(cycleVector));
			SerializeField(s, nameof(triggerEvent));
		}
		public override uint? ClassCRC => 0x4237FE9C;
	}
}

