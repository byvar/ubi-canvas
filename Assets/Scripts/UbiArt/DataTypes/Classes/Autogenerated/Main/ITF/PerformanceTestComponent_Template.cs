using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PerformanceTestComponent_Template : ActorComponent_Template {
		public CArrayO<Path> spawns;
		public Vec3d offset;
		public Vec3d limits;
		public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.VH) {
				spawns = s.SerializeObject<CArrayO<Path>>(spawns, name: "spawns");
				offset = s.SerializeObject<Vec3d>(offset, name: "offset");
				limits = s.SerializeObject<Vec3d>(limits, name: "limits");
				seed = s.Serialize<uint>(seed, name: "seed");
			} else {
				spawns = s.SerializeObject<CArrayO<Path>>(spawns, name: "spawns");
				spawns = s.SerializeObject<CArrayO<Path>>(spawns, name: "spawns");
				offset = s.SerializeObject<Vec3d>(offset, name: "offset");
				limits = s.SerializeObject<Vec3d>(limits, name: "limits");
				seed = s.Serialize<uint>(seed, name: "seed");
			}
		}
		public override uint? ClassCRC => 0x8EB59A46;
	}
}

