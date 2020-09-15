using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossPlantNodeComponent_Template : ActorComponent_Template {
		[Serialize("anim"        )] public StringID anim;
		[Serialize("animPlayRate")] public float animPlayRate;
		[Serialize("cycleVector" )] public Vec2d cycleVector;
		[Serialize("triggerEvent")] public RO2_EventNodeReached triggerEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animPlayRate));
			SerializeField(s, nameof(cycleVector));
			SerializeField(s, nameof(triggerEvent));
		}
		public override uint? ClassCRC => 0x818CF0CB;
	}
}

