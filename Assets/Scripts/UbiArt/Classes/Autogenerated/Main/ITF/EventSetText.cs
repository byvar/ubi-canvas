using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetText : Event {
		public SmartLocId text;
		public Placeholder smartLocId;
		public uint styleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				smartLocId = s.SerializeObject<Placeholder>(smartLocId, name: "smartLocId");
				styleIndex = s.Serialize<uint>(styleIndex, name: "styleIndex");
			} else {
				text = s.SerializeObject<SmartLocId>(text, name: "text");
			}
		}
		public override uint? ClassCRC => 0xC474850E;
	}
}

