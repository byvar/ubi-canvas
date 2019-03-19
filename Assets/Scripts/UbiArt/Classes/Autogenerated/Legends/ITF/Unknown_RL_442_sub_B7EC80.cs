using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_442_sub_B7EC80 : CSerializable {
		[Serialize("enterExit"                     )] public int enterExit;
		[Serialize("exitOnly"                      )] public int exitOnly;
		[Serialize("useCameraBorderSpawn"          )] public int useCameraBorderSpawn;
		[Serialize("cameraBorderSpawnOffset"       )] public float cameraBorderSpawnOffset;
		[Serialize("cameraBorderSpawnPlayersOffset")] public float cameraBorderSpawnPlayersOffset;
		[Serialize("playersSpawnPosList"           )] public Placeholder playersSpawnPosList;
		[Serialize("visualScaleMultiplier"         )] public float visualScaleMultiplier;
		[Serialize("checkpointIn"                  )] public int checkpointIn;
		[Serialize("quickLanding"                  )] public int quickLanding;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterExit));
			SerializeField(s, nameof(exitOnly));
			SerializeField(s, nameof(useCameraBorderSpawn));
			SerializeField(s, nameof(cameraBorderSpawnOffset));
			SerializeField(s, nameof(cameraBorderSpawnPlayersOffset));
			SerializeField(s, nameof(playersSpawnPosList));
			SerializeField(s, nameof(visualScaleMultiplier));
			SerializeField(s, nameof(checkpointIn));
			SerializeField(s, nameof(quickLanding));
		}
		public override uint? ClassCRC => 0xFB860F4D;
	}
}

