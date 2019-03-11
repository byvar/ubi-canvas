using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhantomComponent_Template : ShapeComponent_Template {
		[Serialize("collisionGroup")] public ECOLLISIONGROUP collisionGroup;
		[Serialize("collisionGroup")] public Enum_collisionGroup collisionGroup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(collisionGroup));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(collisionGroup));
			} else {
			}
		}
		public enum ECOLLISIONGROUP {
			[Serialize("ECOLLISIONGROUP_NONE"     )] NONE = 1,
			[Serialize("ECOLLISIONGROUP_POLYLINE" )] POLYLINE = 2,
			[Serialize("ECOLLISIONGROUP_CHARACTER")] CHARACTER = 4,
			[Serialize("ECOLLISIONGROUP_ITEMS"    )] ITEMS = 8,
		}
		public enum Enum_collisionGroup {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x684EF200;
	}
}

