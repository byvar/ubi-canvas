using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossPlantNodeComponent_Template : ActorComponent_Template {
		public StringID anim;
		public float animPlayRate;
		public Vec2d cycleVector;
		public RO2_EventNodeReached triggerEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			animPlayRate = s.Serialize<float>(animPlayRate, name: "animPlayRate");
			cycleVector = s.SerializeObject<Vec2d>(cycleVector, name: "cycleVector");
			triggerEvent = s.SerializeObject<RO2_EventNodeReached>(triggerEvent, name: "triggerEvent");
		}
		public override uint? ClassCRC => 0x818CF0CB;
	}
}

