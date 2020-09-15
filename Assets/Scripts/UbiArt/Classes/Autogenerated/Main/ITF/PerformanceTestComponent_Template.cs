using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PerformanceTestComponent_Template : ActorComponent_Template {
		[Serialize("spawns")] public CArray<Path> spawns;
		[Serialize("offset")] public Vec3d offset;
		[Serialize("limits")] public Vec3d limits;
		[Serialize("seed"  )] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(spawns));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(limits));
				SerializeField(s, nameof(seed));
			} else {
				SerializeField(s, nameof(spawns));
				SerializeField(s, nameof(spawns));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(limits));
				SerializeField(s, nameof(seed));
			}
		}
		public override uint? ClassCRC => 0x8EB59A46;
	}
}

