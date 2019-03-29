using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_197_sub_786C50 : BTAIComponent_Template {
		[Serialize("reward")] public Generic<Event> reward;
		[Serialize("fx"    )] public Path fx;
		[Serialize("air"   )] public int air;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(air));
		}
		public override uint? ClassCRC => 0x4F73A6C1;
	}
}

