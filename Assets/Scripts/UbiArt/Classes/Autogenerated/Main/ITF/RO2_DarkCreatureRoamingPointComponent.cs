using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureRoamingPointComponent : ActorComponent {
		public float TimerMin;
		public float TimerMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				TimerMin = s.Serialize<float>(TimerMin, name: "TimerMin");
				TimerMax = s.Serialize<float>(TimerMax, name: "TimerMax");
			}
		}
		public override uint? ClassCRC => 0xC3E02D49;
	}
}

