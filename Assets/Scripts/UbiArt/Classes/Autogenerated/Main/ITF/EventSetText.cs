using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class EventSetText : Event {
		public SmartLocId text;
		public Placeholder smartLocId;
		public uint styleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				smartLocId = s.SerializeObject<Placeholder>(smartLocId, name: "smartLocId");
				styleIndex = s.Serialize<uint>(styleIndex, name: "styleIndex");
			} else {
				text = s.SerializeObject<SmartLocId>(text, name: "text");
			}
		}
		public override uint? ClassCRC => 0xC474850E;
	}
}

