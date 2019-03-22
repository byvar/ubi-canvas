using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafScrewComponent : RO2_AIComponent {
		[Serialize("actorSpawnedPath")] public Path actorSpawnedPath;
		[Serialize("terminated"      )] public bool terminated;
		[Serialize("actorSpawnType"  )] public SpawnActorType actorSpawnType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorSpawnedPath));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(terminated));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(actorSpawnType));
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

