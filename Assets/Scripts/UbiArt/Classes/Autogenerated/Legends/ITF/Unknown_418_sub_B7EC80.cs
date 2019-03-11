using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_418_sub_B7EC80 : CSerializable {
		[Serialize("enterExit"                     )] public bool enterExit;
		[Serialize("exitOnly"                      )] public bool exitOnly;
		[Serialize("useCameraBorderSpawn"          )] public bool useCameraBorderSpawn;
		[Serialize("cameraBorderSpawnOffset"       )] public float cameraBorderSpawnOffset;
		[Serialize("cameraBorderSpawnPlayersOffset")] public float cameraBorderSpawnPlayersOffset;
		[Serialize("playersSpawnPosList"           )] public Placeholder playersSpawnPosList;
		[Serialize("visualScaleMultiplier"         )] public float visualScaleMultiplier;
		[Serialize("checkpointIn"                  )] public bool checkpointIn;
		[Serialize("quickLanding"                  )] public bool quickLanding;
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

