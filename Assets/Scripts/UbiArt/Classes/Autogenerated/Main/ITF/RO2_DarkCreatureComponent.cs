using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureComponent : ActorComponent {
		public uint MaxCreatures;
		public bool AllAtStart;
		public RO2_DarkCreatureSimulation DarkCreatureSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				MaxCreatures = s.Serialize<uint>(MaxCreatures, name: "MaxCreatures");
				AllAtStart = s.Serialize<bool>(AllAtStart, name: "AllAtStart");
				DarkCreatureSimulation = s.SerializeObject<RO2_DarkCreatureSimulation>(DarkCreatureSimulation, name: "DarkCreatureSimulation");
			}
		}
		public override uint? ClassCRC => 0x44C66E5E;
	}
}

