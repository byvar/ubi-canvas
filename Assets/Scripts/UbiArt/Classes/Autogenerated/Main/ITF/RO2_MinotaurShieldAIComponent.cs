using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MinotaurShieldAIComponent : RO2_AIComponent {
		[Serialize("standOnce"          )] public bool standOnce;
		[Serialize("useDestructionDelay")] public bool useDestructionDelay;
		[Serialize("dead"               )] public bool dead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(standOnce), boolAsByte: true);
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(dead));
				}
			} else {
				SerializeField(s, nameof(standOnce));
				SerializeField(s, nameof(useDestructionDelay));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(dead));
				}
			}
		}
		public override uint? ClassCRC => 0x126B81D8;
	}
}

