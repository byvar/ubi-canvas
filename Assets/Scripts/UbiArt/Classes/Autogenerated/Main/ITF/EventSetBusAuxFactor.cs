using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusAuxFactor : Event {
		[Serialize("aux"   )] public uint aux;
		[Serialize("factor")] public float factor;
		[Serialize("bus"   )] public StringID bus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(aux));
				SerializeField(s, nameof(factor));
			} else {
			}
		}
		public override uint? ClassCRC => 0x990E6AE9;
	}
}

