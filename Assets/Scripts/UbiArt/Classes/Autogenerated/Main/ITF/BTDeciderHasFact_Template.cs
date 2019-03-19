using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTDeciderHasFact_Template : BTDecider_Template {
		[Serialize("factsHave"   )] public CArray<StringID> factsHave;
		[Serialize("factsNotHave")] public CArray<StringID> factsNotHave;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(factsHave));
				SerializeField(s, nameof(factsNotHave));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8C782467;
	}
}

