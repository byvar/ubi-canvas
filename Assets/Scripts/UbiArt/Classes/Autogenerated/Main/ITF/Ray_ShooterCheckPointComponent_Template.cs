using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCheckPointComponent_Template : CheckpointComponent_Template {
		public int enterExit;
		public int exitOnly;
		public int useCameraBorderSpawn;
		public float cameraBorderSpawnOffset;
		public float cameraBorderSpawnPlayersOffset;
		public CList<PlayerSpawnPos> playersSpawnPosList;
		public Generic<Ray_ShooterGameModeParameters> shooterGameModeParameters; // It's generic, check classCRC
		public float visualScaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterExit = s.Serialize<int>(enterExit, name: "enterExit");
			exitOnly = s.Serialize<int>(exitOnly, name: "exitOnly");
			useCameraBorderSpawn = s.Serialize<int>(useCameraBorderSpawn, name: "useCameraBorderSpawn");
			cameraBorderSpawnOffset = s.Serialize<float>(cameraBorderSpawnOffset, name: "cameraBorderSpawnOffset");
			cameraBorderSpawnPlayersOffset = s.Serialize<float>(cameraBorderSpawnPlayersOffset, name: "cameraBorderSpawnPlayersOffset");
			playersSpawnPosList = s.SerializeObject<CList<PlayerSpawnPos>>(playersSpawnPosList, name: "playersSpawnPosList");
			shooterGameModeParameters = s.SerializeObject<Generic<Ray_ShooterGameModeParameters>>(shooterGameModeParameters, name: "shooterGameModeParameters");
			visualScaleMultiplier = s.Serialize<float>(visualScaleMultiplier, name: "visualScaleMultiplier");
		}
		public override uint? ClassCRC => 0xA3F787D9;
	}
}

