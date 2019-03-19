using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("actorPaths"                 )] public CList<Path> actorPaths;
		[Serialize("disabled"                   )] public bool disabled;
		[Serialize("changeScale"                )] public bool changeScale;
		[Serialize("AlwaysActiveBeforeSpawnDone")] public bool AlwaysActiveBeforeSpawnDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorPaths));
			SerializeField(s, nameof(disabled));
			SerializeField(s, nameof(changeScale));
			SerializeField(s, nameof(AlwaysActiveBeforeSpawnDone));
		}
		public override uint? ClassCRC => 0xB31F18B1;
	}
}

