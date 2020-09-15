using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class DRCStim : EventStim {
		public uint level;
		public Vec2d direction;
		public uint faction;
		public Vec3d fxPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			level = s.Serialize<uint>(level, name: "level");
			direction = s.SerializeObject<Vec2d>(direction, name: "direction");
			faction = s.Serialize<uint>(faction, name: "faction");
			fxPos = s.SerializeObject<Vec3d>(fxPos, name: "fxPos");
		}
		public override uint? ClassCRC => 0xC9E31CF9;
	}
}

