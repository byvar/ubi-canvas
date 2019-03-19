using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureRoamingPointComponent : ActorComponent {
		[Serialize("TimerMin")] public float TimerMin;
		[Serialize("TimerMax")] public float TimerMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(TimerMin));
				SerializeField(s, nameof(TimerMax));
			}
		}
		public override uint? ClassCRC => 0xC3E02D49;
	}
}

