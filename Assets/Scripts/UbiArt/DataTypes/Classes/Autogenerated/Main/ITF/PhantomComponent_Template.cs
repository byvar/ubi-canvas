using System;
namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhantomComponent_Template : ShapeComponent_Template {
		public ECOLLISIONGROUP collisionGroup = ECOLLISIONGROUP.NONE;
		public uint collisionGroup2 = 1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
				collisionGroup2 = s.Serialize<uint>(collisionGroup2, name: "collisionGroup");
			} else {
				collisionGroup = s.Serialize<ECOLLISIONGROUP>(collisionGroup, name: "collisionGroup");
			}
		}
		[Flags]
		public enum ECOLLISIONGROUP {
			[Serialize("ECOLLISIONGROUP_NONE"     )] NONE = 1,
			[Serialize("ECOLLISIONGROUP_POLYLINE" )] POLYLINE = 2,
			[Serialize("ECOLLISIONGROUP_CHARACTER")] CHARACTER = 4,
			[Serialize("ECOLLISIONGROUP_ITEMS"    )] ITEMS = 8,
		}
		public override uint? ClassCRC => 0x684EF200;
	}
}

