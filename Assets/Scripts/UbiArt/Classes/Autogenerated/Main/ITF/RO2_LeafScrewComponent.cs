using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafScrewComponent : RO2_AIComponent {
		public Path actorSpawnedPath;
		public bool terminated;
		public SpawnActorType actorSpawnType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorSpawnedPath = s.SerializeObject<Path>(actorSpawnedPath, name: "actorSpawnedPath");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				terminated = s.Serialize<bool>(terminated, name: "terminated");
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				actorSpawnType = s.Serialize<SpawnActorType>(actorSpawnType, name: "actorSpawnType");
			}
		}
		public enum SpawnActorType {
			[Serialize("SpawnActorType_Other"   )] Other = 0,
			[Serialize("SpawnAcorType_Turnip"   )] Turnip = 1,
			[Serialize("SpawnActorType_LumsCage")] LumsCage = 2,
		}
		public override uint? ClassCRC => 0x35F701E3;
	}
}

