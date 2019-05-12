using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCheckPointComponent_Template : CheckpointComponent_Template {
		[Serialize("enterExit"                     )] public int enterExit;
		[Serialize("exitOnly"                      )] public int exitOnly;
		[Serialize("useCameraBorderSpawn"          )] public int useCameraBorderSpawn;
		[Serialize("cameraBorderSpawnOffset"       )] public float cameraBorderSpawnOffset;
		[Serialize("cameraBorderSpawnPlayersOffset")] public float cameraBorderSpawnPlayersOffset;
		[Serialize("playersSpawnPosList"           )] public CList<PlayerSpawnPos> playersSpawnPosList;
		[Serialize("shooterGameModeParameters"     )] public Generic<Ray_ShooterGameModeParameters> shooterGameModeParameters; // It's generic, check classCRC
		[Serialize("visualScaleMultiplier"         )] public float visualScaleMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterExit));
			SerializeField(s, nameof(exitOnly));
			SerializeField(s, nameof(useCameraBorderSpawn));
			SerializeField(s, nameof(cameraBorderSpawnOffset));
			SerializeField(s, nameof(cameraBorderSpawnPlayersOffset));
			SerializeField(s, nameof(playersSpawnPosList));
			SerializeField(s, nameof(shooterGameModeParameters));
			SerializeField(s, nameof(visualScaleMultiplier));
		}
		public override uint? ClassCRC => 0xA3F787D9;
	}
}

