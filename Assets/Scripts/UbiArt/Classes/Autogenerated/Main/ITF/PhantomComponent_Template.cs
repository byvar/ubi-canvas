using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.VH | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class PhantomComponent_Template : ShapeComponent_Template {
		[Serialize("collisionGroup")] public Enum_RJR_0 collisionGroup;
		[Serialize("collisionGroup")] public Enum_RFR_0 collisionGroup;
		[Serialize("collisionGroup")] public Enum_collisionGroup collisionGroup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(collisionGroup));
			} else if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(collisionGroup));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(collisionGroup));
			} else {
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
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

