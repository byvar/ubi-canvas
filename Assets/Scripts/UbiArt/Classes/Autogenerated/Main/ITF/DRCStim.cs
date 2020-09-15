using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class DRCStim : EventStim {
		[Serialize("level"    )] public uint level;
		[Serialize("direction")] public Vec2d direction;
		[Serialize("faction"  )] public uint faction;
		[Serialize("fxPos"    )] public Vec3d fxPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(level));
			SerializeField(s, nameof(direction));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(fxPos));
		}
		public override uint? ClassCRC => 0xC9E31CF9;
	}
}

