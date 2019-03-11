using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DarkCreatureComponent : ActorComponent {
		[Serialize("MaxCreatures"          )] public uint MaxCreatures;
		[Serialize("AllAtStart"            )] public bool AllAtStart;
		[Serialize("DarkCreatureSimulation")] public RO2_DarkCreatureSimulation DarkCreatureSimulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(MaxCreatures));
				SerializeField(s, nameof(AllAtStart));
				SerializeField(s, nameof(DarkCreatureSimulation));
			}
		}
		public override uint? ClassCRC => 0x44C66E5E;
	}
}

