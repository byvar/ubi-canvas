using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterCheckPointComponent_Template : CSerializable {
		[Serialize("enterExit"                     )] public bool enterExit;
		[Serialize("exitOnly"                      )] public bool exitOnly;
		[Serialize("useCameraBorderSpawn"          )] public bool useCameraBorderSpawn;
		[Serialize("cameraBorderSpawnOffset"       )] public float cameraBorderSpawnOffset;
		[Serialize("cameraBorderSpawnPlayersOffset")] public float cameraBorderSpawnPlayersOffset;
		[Serialize("playersSpawnPosList"           )] public Placeholder playersSpawnPosList;
		[Serialize("shooterGameModeParameters"     )] public Placeholder shooterGameModeParameters;
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

