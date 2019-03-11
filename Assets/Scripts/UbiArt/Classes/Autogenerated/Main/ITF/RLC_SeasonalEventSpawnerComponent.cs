using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_SeasonalEventSpawnerComponent : ActorComponent {
		[Serialize("selectedPathIndex")] public uint selectedPathIndex;
		[Serialize("weight"           )] public uint weight;
		[Serialize("GFXParam"         )] public GFXPrimitiveParam GFXParam;
		[Serialize("triggerSpawn"     )] public bool triggerSpawn;
		[Serialize("spawneeCanDrown"  )] public bool spawneeCanDrown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(selectedPathIndex));
			SerializeField(s, nameof(weight));
			SerializeField(s, nameof(GFXParam));
			SerializeField(s, nameof(triggerSpawn));
			SerializeField(s, nameof(spawneeCanDrown));
		}
		public override uint? ClassCRC => 0xD33156E5;
	}
}

