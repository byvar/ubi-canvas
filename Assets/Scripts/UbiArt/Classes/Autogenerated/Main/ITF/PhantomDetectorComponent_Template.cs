using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhantomDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("allowDeadActors")] public bool allowDeadActors;
		[Serialize("factionToDetect")] public uint factionToDetect;
		[Serialize("Enum_VH_0__2"   )] public Enum_VH_0 Enum_VH_0__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(factionToDetect));
				SerializeField(s, nameof(allowDeadActors));
				SerializeField(s, nameof(Enum_VH_0__2));
			} else {
				SerializeField(s, nameof(allowDeadActors));
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

