using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetText : Event {
		[Serialize("text"      )] public SmartLocId text;
		[Serialize("smartLocId")] public Placeholder smartLocId;
		[Serialize("styleIndex")] public uint styleIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(smartLocId));
				SerializeField(s, nameof(styleIndex));
			} else {
				SerializeField(s, nameof(text));
			}
		}
		public override uint? ClassCRC => 0xC474850E;
	}
}

