using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ScoreRecapRewardComponent_Template : ActorComponent_Template {
		public float idleTime;
		public float finalScale;
		public float transitionTime;
		public StringID appear;
		public StringID idle;
		public StringID disappear;
		public uint nbLoopDuringTransition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleTime = s.Serialize<float>(idleTime, name: "idleTime");
			finalScale = s.Serialize<float>(finalScale, name: "finalScale");
			transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
			appear = s.SerializeObject<StringID>(appear, name: "appear");
			idle = s.SerializeObject<StringID>(idle, name: "idle");
			disappear = s.SerializeObject<StringID>(disappear, name: "disappear");
			nbLoopDuringTransition = s.Serialize<uint>(nbLoopDuringTransition, name: "nbLoopDuringTransition");
		}
		public override uint? ClassCRC => 0x8639B35F;
	}
}

