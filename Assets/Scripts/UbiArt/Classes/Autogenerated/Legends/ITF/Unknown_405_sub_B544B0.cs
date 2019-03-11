using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_405_sub_B544B0 : CSerializable {
		[Serialize("SpawnLimitNb")] public bool SpawnLimitNb;
		[Serialize("WaveSpawnNb" )] public uint WaveSpawnNb;
		[Serialize("NbToRespawn" )] public uint NbToRespawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(SpawnLimitNb));
				SerializeField(s, nameof(WaveSpawnNb));
				SerializeField(s, nameof(NbToRespawn));
			}
		}
		public override uint? ClassCRC => 0xDF60AF3D;
	}
}

