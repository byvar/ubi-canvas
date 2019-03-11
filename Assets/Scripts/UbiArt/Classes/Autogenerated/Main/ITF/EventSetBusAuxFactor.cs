using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetBusAuxFactor : Event {
		[Serialize("sender")] public uint sender;
		[Serialize("aux"   )] public uint aux;
		[Serialize("factor")] public float factor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(aux));
				SerializeField(s, nameof(factor));
			} else {
			}
		}
		public override uint? ClassCRC => 0x990E6AE9;
	}
}

