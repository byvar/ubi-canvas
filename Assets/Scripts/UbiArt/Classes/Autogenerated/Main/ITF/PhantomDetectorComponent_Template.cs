using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class PhantomDetectorComponent_Template : ShapeDetectorComponent_Template {
		public bool allowDeadActors;
		public uint factionToDetect;
		public Enum_VH_0 Enum_VH_0__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				factionToDetect = s.Serialize<uint>(factionToDetect, name: "factionToDetect");
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
			} else if (s.Settings.game == Settings.Game.VH) {
				factionToDetect = s.Serialize<uint>(factionToDetect, name: "factionToDetect");
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
				Enum_VH_0__2 = s.Serialize<Enum_VH_0>(Enum_VH_0__2, name: "Enum_VH_0__2");
			} else {
				allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1038")] Value_1038 = 1038,
			[Serialize("Value_4"   )] Value_4 = 4,
			[Serialize("Value_2"   )] Value_2 = 2,
			[Serialize("Value_8"   )] Value_8 = 8,
			[Serialize("Value_66"  )] Value_66 = 66,
			[Serialize("Value_0"   )] Value_0 = 0,
		}
		public override uint? ClassCRC => 0xF530E437;
	}
}

