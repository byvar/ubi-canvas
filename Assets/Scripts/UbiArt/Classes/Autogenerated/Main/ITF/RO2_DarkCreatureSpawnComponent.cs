using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureSpawnComponent : ActorComponent {
		[Serialize("SpawnBySec"    )] public int SpawnBySec;
		[Serialize("MaxNumber"     )] public int MaxNumber;
		[Serialize("IsDirectional" )] public bool IsDirectional;
		[Serialize("OpeningAngle"  )] public float OpeningAngle;
		[Serialize("SpawnForce"    )] public float SpawnForce;
		[Serialize("ImmediateStart")] public bool ImmediateStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(SpawnBySec));
				SerializeField(s, nameof(MaxNumber));
				SerializeField(s, nameof(IsDirectional));
				SerializeField(s, nameof(OpeningAngle));
				SerializeField(s, nameof(SpawnForce));
				SerializeField(s, nameof(ImmediateStart));
			}
		}
		public override uint? ClassCRC => 0x81D227C5;
	}
}

