using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhantomComponent_Template : ShapeComponent_Template {
		public Enum_collisionGroup collisionGroup;
		public uint collisionGroup2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM) {
				collisionGroup2 = s.Serialize<uint>(collisionGroup2, name: "collisionGroup");
			} else {
				collisionGroup = s.Serialize<Enum_collisionGroup>(collisionGroup, name: "collisionGroup");
			}
		}
		[Flags]
		public enum Enum_collisionGroup {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0x684EF200;
	}
}

