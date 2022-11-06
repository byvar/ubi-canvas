using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_197_sub_786C50 : BTAIComponent_Template {
		public Generic<Event> reward;
		public Path fx;
		public int air;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<Event>>(reward, name: "reward");
			fx = s.SerializeObject<Path>(fx, name: "fx");
			air = s.Serialize<int>(air, name: "air");
		}
		public override uint? ClassCRC => 0x4F73A6C1;
	}
}

