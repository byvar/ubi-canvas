using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DarkCreatureSpawnComponent : ActorComponent {
		[Serialize("SpawnBySec"    )] public int SpawnBySec;
		[Serialize("MaxNumber"     )] public int MaxNumber;
		[Serialize("IsDirectional" )] public bool IsDirectional;
		[Serialize("OpeningAngle"  )] public float OpeningAngle;
		[Serialize("SpawnForce"    )] public float SpawnForce;
		[Serialize("ImmediateStart")] public bool ImmediateStart;
		[Serialize("SpawnBySec"    )] public bool SpawnBySec;
		[Serialize("MaxNumber"     )] public bool MaxNumber;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MaxNumber));
					SerializeField(s, nameof(IsDirectional));
					SerializeField(s, nameof(OpeningAngle));
					SerializeField(s, nameof(SpawnForce));
					SerializeField(s, nameof(ImmediateStart));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SpawnBySec));
					SerializeField(s, nameof(MaxNumber));
					SerializeField(s, nameof(IsDirectional));
					SerializeField(s, nameof(OpeningAngle));
					SerializeField(s, nameof(SpawnForce));
					SerializeField(s, nameof(ImmediateStart));
				}
			}
		}
		public override uint? ClassCRC => 0x81D227C5;
	}
}

