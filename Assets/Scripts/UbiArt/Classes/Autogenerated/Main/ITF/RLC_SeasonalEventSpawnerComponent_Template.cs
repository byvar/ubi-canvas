using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventSpawnerComponent_Template : ActorComponent_Template {
		public CList<Path> actorPaths;
		public bool disabled;
		public bool changeScale;
		public bool AlwaysActiveBeforeSpawnDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorPaths = s.SerializeObject<CList<Path>>(actorPaths, name: "actorPaths");
			disabled = s.Serialize<bool>(disabled, name: "disabled");
			changeScale = s.Serialize<bool>(changeScale, name: "changeScale");
			AlwaysActiveBeforeSpawnDone = s.Serialize<bool>(AlwaysActiveBeforeSpawnDone, name: "AlwaysActiveBeforeSpawnDone");
		}
		public override uint? ClassCRC => 0xB31F18B1;
	}
}

