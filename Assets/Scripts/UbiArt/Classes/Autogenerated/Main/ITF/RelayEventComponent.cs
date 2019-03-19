using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class RelayEventComponent : ActorComponent {
		[Serialize("relays"              )] public CList<RelayData> relays;
		[Serialize("receiveBroadcast"    )] public bool receiveBroadcast;
		[Serialize("CArray<RelayData>__0")] public CArray<RelayData> CArray_RelayData__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_RelayData__0));
			} else {
				SerializeField(s, nameof(relays));
				SerializeField(s, nameof(receiveBroadcast));
			}
		}
		public override uint? ClassCRC => 0x7291EA2B;
	}
}

