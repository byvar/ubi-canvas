using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTDeciderHasFact_Template : BTDecider_Template {
		public CArray<StringID> factsHave;
		public CArray<StringID> factsNotHave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				factsHave = s.SerializeObject<CArray<StringID>>(factsHave, name: "factsHave");
				factsNotHave = s.SerializeObject<CArray<StringID>>(factsNotHave, name: "factsNotHave");
			} else {
			}
		}
		public override uint? ClassCRC => 0x8C782467;
	}
}

