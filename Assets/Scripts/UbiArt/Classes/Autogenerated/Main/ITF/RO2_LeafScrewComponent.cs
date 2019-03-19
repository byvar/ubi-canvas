using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafScrewComponent : RO2_AIComponent {
		[Serialize("actorSpawnedPath")] public Path actorSpawnedPath;
		[Serialize("terminated"      )] public bool terminated;
		[Serialize("actorSpawnType"  )] public SpawnAc actorSpawnType;
		[Serialize("actorSpawnType"  )] public Enum_actorSpawnType actorSpawnType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(actorSpawnedPath));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(terminated));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(actorSpawnType));
				}
			} else {
				SerializeField(s, nameof(actorSpawnedPath));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(terminated));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(actorSpawnType));
				}
			}
		}
		public enum SpawnAc {
			[Serialize("SpawnActorType_Other"   )] torType_Other = 0,
			[Serialize("SpawnAcorType_Turnip"   )] orType_Turnip = 1,
			[Serialize("SpawnActorType_LumsCage")] torType_LumsCage = 2,
		}
		public enum Enum_actorSpawnType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x35F701E3;
	}
}

