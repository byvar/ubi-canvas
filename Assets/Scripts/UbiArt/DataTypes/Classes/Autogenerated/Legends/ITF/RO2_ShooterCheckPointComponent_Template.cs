using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCheckPointComponent_Template : CheckpointComponent_Template {
		public int enterExit;
		public int exitOnly;
		public int useCameraBorderSpawn;
		public float cameraBorderSpawnOffset;
		public float cameraBorderSpawnPlayersOffset;
		public CListO<PlayerSpawnPos> playersSpawnPosList;
		public float visualScaleMultiplier;
		public int checkpointIn;
		public int quickLanding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterExit = s.Serialize<int>(enterExit, name: "enterExit");
			exitOnly = s.Serialize<int>(exitOnly, name: "exitOnly");
			useCameraBorderSpawn = s.Serialize<int>(useCameraBorderSpawn, name: "useCameraBorderSpawn");
			cameraBorderSpawnOffset = s.Serialize<float>(cameraBorderSpawnOffset, name: "cameraBorderSpawnOffset");
			cameraBorderSpawnPlayersOffset = s.Serialize<float>(cameraBorderSpawnPlayersOffset, name: "cameraBorderSpawnPlayersOffset");
			playersSpawnPosList = s.SerializeObject<CListO<PlayerSpawnPos>>(playersSpawnPosList, name: "playersSpawnPosList");
			visualScaleMultiplier = s.Serialize<float>(visualScaleMultiplier, name: "visualScaleMultiplier");
			checkpointIn = s.Serialize<int>(checkpointIn, name: "checkpointIn");
			quickLanding = s.Serialize<int>(quickLanding, name: "quickLanding");
		}
		public override uint? ClassCRC => 0xFB860F4D;
	}
}

