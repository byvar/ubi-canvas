using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.COL)]
	public partial class EventStim : Event {
		public Vec2d pos;
		public Vec2d prevPos;
		public float angle;
		public float z;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
			} else {
				pos = s.SerializeObject<Vec2d>(pos, name: "pos");
				prevPos = s.SerializeObject<Vec2d>(prevPos, name: "prevPos");
				angle = s.Serialize<float>(angle, name: "angle");
				z = s.Serialize<float>(z, name: "z");
			}
		}
		public override uint? ClassCRC => 0x12E41BB6;
	}
}

