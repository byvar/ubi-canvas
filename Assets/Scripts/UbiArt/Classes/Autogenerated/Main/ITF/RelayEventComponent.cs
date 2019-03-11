using UnityEngine;

namespace UbiArt.ITF {
	public partial class RelayEventComponent : ActorComponent {
		[Serialize("relays"          )] public CList<RelayData> relays;
		[Serialize("receiveBroadcast")] public bool receiveBroadcast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(relays));
				SerializeField(s, nameof(receiveBroadcast));
			}
		}
		public override uint? ClassCRC => 0x7291EA2B;
	}
}

